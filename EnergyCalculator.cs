using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clusterization_algorithms
{
    class EnergyCalculator // DEEC algorithm
    {
        Graphic graphic;
        Dictionary<Point, int> allNodes; // int - num of cluster
        private Dictionary<Point, int> nodesLevelCharge = new Dictionary<Point, int> { };
        List<int> clustersEnergy = new List<int> { };
        int stationUsedE = 0; //energy used by station

        //--------- Energy consumption parameters ------------
        double E_fs = 0.01;//nJ(10^-9) amplifier energy, free space model (short distance) | d<d0
        //double E_mp = 1300000; //nJ // multipath fading model (large distance) | d >= d0
        int E_elec = 50; //nJ, energy for work signal transmission/recieve
        int node_E = 500000000; //nJ; = 0,5J // initial node energy
        double d0 = 87.7; // (m) distance threshold for swapping amplification models
        int package = 4000; // bytes, package size
        //int package = Calculator.genRandInt(20, 65535);
        //----------------------------------------------------

        public EnergyCalculator(Graphic graphic, Dictionary<Point, int> allNodes)
        {
            this.graphic = graphic;
            this.allNodes = allNodes;

            foreach (var node in allNodes)
                nodesLevelCharge.Add(node.Key, node_E);
        }

        public Dictionary<Point, int> GetNodesChargeDictionary()
        {

            Dictionary<Point, int> chargeList = new Dictionary<Point, int> { };
            int onePercent = node_E / 100; // 1% = ?nJ

            foreach (var node in nodesLevelCharge)
            {
                int charge = node.Value / onePercent; // (%)
                chargeList.Add(node.Key, charge);
            }
            return chargeList;
        }

        public void CalculteAllNodesEnergy(ConnectionType connectionType, Dictionary<Point, int> nodesClustered, List<Point> routeList, int stationHeight) {

            for (int i = 1; i < routeList.Count - 1; i++) {
                List<Point> cluster = Calculator.getClusterList(i, nodesClustered);

                switch (connectionType) {

                    case ConnectionType.DT_to_Center:
                        Start_DT_Protocol(cluster, stationHeight);
                        break;

                    case ConnectionType.DT_to_Route:
                        Start_DT_ToRoute(cluster, stationHeight, routeList);
                        break;

                    case ConnectionType.PP_to_Center:
                        Start_PP_Protocol(cluster, stationHeight);
                        break;

                    case ConnectionType.PP_to_Route:
                        Start_PP_ToRoute(cluster, stationHeight, routeList);
                        break;
                }
            }
        }

        public void Start_PP_ToRoute(List<Point> cluster, int stationHeight, List<Point> routeList) {
            Point center = Calculator.findCentroid(cluster);
            List<Point> routeFragment = Calculator.getRouteFragment(center, routeList);

        }

        public void Start_PP_Protocol(List<Point> cluster, int stationHeight) {

            Point center = Calculator.findCentroid(cluster);

            for (int i = 0; i < cluster.Count; i++) {
                
                Point closer = center;
                double dist_i_to_center = Calculator.calcDistance(cluster[i], center);
                double dist_to_closer = dist_i_to_center;

                for (int j = 0; j < cluster.Count; j++) {
                    if (i != j) {
                        double dist_to_node = Calculator.calcDistance(cluster[i], cluster[j]);
                        double dist_j_to_center = Calculator.calcDistance(cluster[j], center);
                        if (dist_to_node < dist_to_closer && dist_j_to_center < dist_i_to_center) {
                            closer = cluster[j];
                            dist_to_closer = dist_to_node;
                        }
                    }
                }

                PPConnection(cluster[i], closer, 0);// high!!!
            }
        }

        public void Start_DT_ToRoute(List<Point> cluster, int stationHeight, List<Point> routeList) { // transmission while station moving on route
            Point center = Calculator.findCentroid(cluster);
            List<Point> routeFragment = Calculator.getRouteFragment(center, routeList);

            for (int i = 0; i < cluster.Count; i++) {

                Point closerFulcrum = center;
                double minDistance = 9999;
                
                for (int j = 0; j < routeFragment.Count - 1; j++) {
                    
                    Point fulcrum = Calculator.find_PointProjection_OnLine(cluster[i], routeFragment[j], routeFragment[j+1]);
                    double distance = Calculator.calcDistance(fulcrum, cluster[i]);
                    
                    if (distance < minDistance) {

                        // Point must be between a,b point (i, i+1 route). Then, check this by length between points:
                        double ab_distance = Calculator.calcDistance(routeFragment[j], routeFragment[j+1]);
                        double af_distance = Calculator.calcDistance(routeFragment[j], fulcrum);
                        double bf_distance = Calculator.calcDistance(routeFragment[j+1], fulcrum);

                        if ((af_distance < ab_distance) && (bf_distance < ab_distance)) { // then fulcrum is between route points
                            minDistance = distance;
                            closerFulcrum = fulcrum;
                        }
                    }
                }

                PPConnection(cluster[i], closerFulcrum, stationHeight);
            }
        }

        public void Start_DT_Protocol(List<Point> cluster, int stationHeight) { // direct transmission in cluster, calculate energy
            Point center = Calculator.findCentroid(cluster);
            foreach (Point point in cluster)
                PPConnection(point, center, stationHeight);
        }

        public int PPConnection(Point node, Point station, int stationHeight) { // transmission from node -> station

            double distH0 = Calculator.calcDistance(node, station);
            double dist = Math.Sqrt(distH0 * distH0 + stationHeight * stationHeight);

            Console.WriteLine("Distance: " + Math.Round(dist) + " Height: " + stationHeight);
            
            double E_transmission = 0;
            Console.WriteLine(node + " " + station);
            //d0 = Math.Sqrt(E_fs / E_mp);

            if (dist < d0) {
                E_transmission = package * E_elec + package * E_fs * Math.Pow(dist, 2); // nJ
                graphic.DrawLine(node, station, Color.Olive);
            }
            else
                //E_transmission = package * E_elec + package * E_mp * Math.Pow(dist, 4); // nJ
                E_transmission = 0;  // no transmittion

            double E_receive = package * E_elec;

            //minus used energy from nodes charge
            if (nodesLevelCharge.TryGetValue(node, out int oldCharge))
            {
                int newCharge = oldCharge - (int)E_transmission;
                nodesLevelCharge.Remove(node);
                nodesLevelCharge.Add(node, newCharge);
            }

            stationUsedE += Convert.ToInt32(E_receive);

            return 0;
        }


    }
}
