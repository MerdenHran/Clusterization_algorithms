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
        Dictionary<Point, int> allNodes; // int - num of cluster
        private Dictionary<Point, int> nodesLevelCharge = new Dictionary<Point, int> { };
        List<int> clustersEnergy = new List<int> { };
        int stationUsedE = 0; //energy used by station

        //--------- Energy consumption parameters ------------
        double E_fs = 0.01;//nJ(10^-9) amplifier energy, free space model (short distance) | d<d0
        double E_mp = 1300000; //nJ // multipath fading model (large distance) | d >= d0
        int E_elec = 50; //nJ, energy for work signal transmission/recieve
        int node_E = 500000000; //nJ; = 0,5J // initial node energy
        double d0 = 87.7; // (m) distance threshold for swapping amplification models
        int package = 4000; // bytes, package size

        public Dictionary<Point, int> GetNodesChargeDictionary() {

            Dictionary<Point, int> chargeList = new Dictionary<Point, int> { };
            int onePercent = node_E / 100; // (nJ)

            foreach (var node in nodesLevelCharge)
            {
                int charge = node.Value / onePercent; // (%)
                chargeList.Add(node.Key, charge);
            }
            return chargeList;
        }

        //int package = Calculator.genRandInt(20, 65535);
        //----------------------------------------------------

        public EnergyCalculator(Dictionary<Point, int> allNodes)
        {
            this.allNodes = allNodes;

            foreach (var node in allNodes)
                nodesLevelCharge.Add(node.Key, node_E);

            //d0 = Math.Sqrt(E_fs / E_mp);
        }

        public void CalculteAllNodesEnergy(Dictionary<Point, int> nodesClustered, List<Point> clusterCenters, int stationHeight) {

            for (int i = 1; i < clusterCenters.Count; i++) {
                List<Point> cluster = Calculator.getCluster(i, nodesClustered);
                Start_DT_Protocol(cluster, stationHeight);



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

            if (dist < d0)
                E_transmission = package * E_elec + package * E_fs * Math.Pow(dist, 2); // nJ
            else
                //E_transmission = package * E_elec + package * E_mp * Math.Pow(dist, 4); // J
                E_transmission = 0;

            double E_receive = package * E_elec;

            //minus used energy from nodes charge
            if (nodesLevelCharge.TryGetValue(node, out int oldCharge))
            {
                int newCharge = oldCharge - (int)E_transmission;
                nodesLevelCharge.Remove(node);
                nodesLevelCharge.Add(node, newCharge);
            }

            stationUsedE += Convert.ToInt32(E_receive);


            if(dist < d0)
                Console.WriteLine("E: " + E_transmission + " nJ -> " + E_receive+" nJ");
            else
                Console.WriteLine("E: " + E_transmission / 1000000000 + " J -> " + E_receive + " nJ");
            
            return 0;
        }


    }
}
