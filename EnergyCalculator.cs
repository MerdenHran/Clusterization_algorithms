using System;
using System.Collections.Generic;
using System.Drawing;

namespace Clusterization_algorithms
{
    class EnergyCalculator // DEEC algorithm
    {
        Graphic graphic;
        Dictionary<Point, int> allNodes; // int - num of cluster
        private Dictionary<Point, int> nodesLevelCharge = new Dictionary<Point, int> { };
        int stationUsedE = 0; //energy used by station

        //--------- Energy consumption parameters ------------
        public double E_fs = 0.01;//nJ(10^-9) amplifier energy, free space model (short distance) | d<d0
        public double E_mp = 0.0000013; //nJ // multipath fading model (large distance) | d >= d0
        public int E_elec = 50; //nJ/bit, energy for work signal transmission/recieve
        public int node_E = 500000000; //nJ; = 0,5J // initial node energy
        public double d0 = 87.7; // (m) distance threshold for swapping amplification models
        public int package = 32000; // bits, package size
        //int package = Calculator.genRandInt(20, 65535);
        //----------------------------------------------------

        public EnergyCalculator(Graphic graphic, Dictionary<Point, int> allNodes)
        {
            this.graphic = graphic;
            this.allNodes = allNodes;
            foreach (var node in allNodes)
                nodesLevelCharge.Add(node.Key, node_E);
        }

        /// <summary>
        /// Set energy model
        /// </summary>
        /// <param name="e_fs">(nJ) (10^-9J) amplifier energy, free space model (short distance) | d<d0</param>
        /// <param name="e_mp">(nJ) multipath fading model (large distance) | d >= d0</param>
        /// <param name="e_elec">(nJ/bit) energy for work signal transmission/recieve</param>
        /// <param name="node_e">(nJ) initial node energy</param>
        /// <param name="d0">(m) distance threshold for swapping amplification models</param>
        /// <param name="package_size">(bit) package size</param>
        public void SetEnergyModel(double e_fs = 0.01, double e_mp = 0.0000013,
                                    int e_elec = 50, int node_e = 500000000,
                                    double d0 = 87.7, int package_size = 32000) { 
            E_fs = e_fs;
            E_mp = e_mp;
            E_elec = e_elec;
            node_E = node_e;
            d0 = this.d0;
            package = package_size;
        }

        /// <summary>
        /// Calculate all nodes charge capacity in (J)!
        /// </summary>
        public double GetNodesCapacity(int nodesCount) {
            double sum_cap = node_E/1000000000.000 * nodesCount; //(J)
            return sum_cap;
        }

        /// <summary>
        /// get total current charge of nodes
        /// </summary>
        /// <returns>summary charge (J)</returns>
        public double GetMapCurrentCharge() {
            double sum_charge = 0;

            foreach (var node in nodesLevelCharge)
                sum_charge += node.Value / 1000000;
            sum_charge = sum_charge / 1000;

            return sum_charge; //(J)
        }

        public double GetMapCurrentChargeInPercents() {
            double total_capacity = GetNodesCapacity(allNodes.Count);
            double sum_charge = GetMapCurrentCharge();
            //double charge_in_percent = total_capacity / 100;
            //double sum_chargeInPercent = sum_charge/charge_in_percent;

            return sum_charge * 100 / total_capacity;
        }

        /// <summary>
        /// (J)
        /// </summary>
        /// <returns></returns>
        public double GetMapUsedEnergy() {
            double total_capacity = GetNodesCapacity(allNodes.Count);
            double sum_charge = GetMapCurrentCharge();
            return total_capacity - sum_charge;
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
            List<int> packetCountList = new List<int> { };

            for (int i = 0; i < allNodes.Count; i++)
                packetCountList.Add(1);

            for (int i = 0; i < cluster.Count; i++)
            {
                Point closer = Calculator.find_PointProjection_OnMultiLine(cluster[i], routeFragment); // set value of closer fulcrum
                double dist_i_to_fulcrum = Calculator.calcDistance(cluster[i], closer);
                double dist_to_closer = dist_i_to_fulcrum;
                int index = -1;

                for (int j = 0; j < cluster.Count; j++)
                {
                    if (i != j)
                    {
                        double dist_to_node = Calculator.calcDistance(cluster[i], cluster[j]);
                        Point j_fulcrum = Calculator.find_PointProjection_OnMultiLine(cluster[j], routeFragment);
                        double dist_j_to_fulcrum = Calculator.calcDistance(cluster[j], j_fulcrum);

                        if (dist_to_node < dist_to_closer && dist_j_to_fulcrum < dist_i_to_fulcrum)
                        {
                            closer = cluster[j];
                            dist_to_closer = dist_to_node;
                            index = j;
                        }
                    }
                }

                if (index == -1)
                    PPConnection(cluster[i], closer, stationHeight, packetCountList[i]);
                else
                {
                    packetCountList[index] = packetCountList[i] + 1; //packet last node + 1 his packet
                    PPConnection(cluster[i], closer, 0, packetCountList[i]);
                }
            }
        }

        public void Start_PP_Protocol(List<Point> cluster, int stationHeight) {

            List<int> packetCountList = new List<int> { };
            Point center = Calculator.findCentroid(cluster);

            for (int i = 0; i < allNodes.Count; i++)
                packetCountList.Add(1);

            for (int i = 0; i < cluster.Count; i++) {
                
                Point closer = center;
                double dist_i_to_center = Calculator.calcDistance(cluster[i], center);
                double dist_to_closer = dist_i_to_center;
                int index = -1;

                for (int j = 0; j < cluster.Count; j++) {
                    if (i != j) {
                        double dist_to_node = Calculator.calcDistance(cluster[i], cluster[j]);
                        double dist_j_to_center = Calculator.calcDistance(cluster[j], center);
                        if (dist_to_node < dist_to_closer && dist_j_to_center < dist_i_to_center) {
                            closer = cluster[j];
                            dist_to_closer = dist_to_node;
                            index = j;
                        }
                    }
                }

                if (index == -1)
                    PPConnection(cluster[i], closer, stationHeight, packetCountList[i]);
                else
                {
                    packetCountList[index] = packetCountList[i] + 1; //packet last node + 1 his packet
                    PPConnection(cluster[i], closer, 0, packetCountList[i]);
                }
            }
        }

        public void Start_DT_ToRoute(List<Point> cluster, int stationHeight, List<Point> routeList) { // transmission while station moving on route
            Point center = Calculator.findCentroid(cluster);
            List<Point> routeFragment = Calculator.getRouteFragment(center, routeList);

            for (int i = 0; i < cluster.Count; i++)
            {
                Point closerFulcrum = Calculator.find_PointProjection_OnMultiLine(cluster[i], routeFragment);
                PPConnection(cluster[i], closerFulcrum, stationHeight);
            }
        }

        public void Start_DT_Protocol(List<Point> cluster, int stationHeight) { // direct transmission in cluster, calculate energy
            Point center = Calculator.findCentroid(cluster);
            foreach (Point point in cluster)
                PPConnection(point, center, stationHeight);
        }

        public int PPConnection(Point node, Point station, int stationHeight, int packetCount = 1) { // transmission from node -> station

            double distH0 = Calculator.calcDistance(node, station);
            double dist = Math.Sqrt(distH0 * distH0 + stationHeight * stationHeight);
            //Console.WriteLine("Distance: " + Math.Round(dist) + " Height: " + stationHeight);
            double E_transmission = 0;
            //Console.WriteLine(node + " " + station);
            //d0 = Math.Sqrt(E_fs / E_mp);

            if (dist < d0)
            {
                E_transmission = (package * packetCount) * E_elec + (package * packetCount) * E_fs * Math.Pow(dist, 2); // nJ
                graphic.DrawLine(node, station, Color.LimeGreen);
            }
            else {
                E_transmission = (package * packetCount) * E_elec + (package * packetCount) * E_mp * Math.Pow(dist, 4); // nJ
                //E_transmission = 0;  // no transmittion
                graphic.DrawLine(node, station, Color.IndianRed);
            }


            double E_receive = (package * packetCount) * E_elec;

            //minus used energy from nodes charge
            if (nodesLevelCharge.TryGetValue(node, out int oldCharge))
            {
                int newCharge = oldCharge - (int)E_transmission;

                if (newCharge < 0) {
                    newCharge = 0;
                    graphic.DrawPoint(node, Brushes.Red);
                }
                    
                nodesLevelCharge.Remove(node);
                nodesLevelCharge.Add(node, newCharge);
            }

            stationUsedE += Convert.ToInt32(E_receive);

            return 0;
        }


    }
}
