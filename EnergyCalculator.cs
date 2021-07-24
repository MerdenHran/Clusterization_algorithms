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
        Dictionary<Point, double> nodesLevelCharge = new Dictionary<Point, double> { };
        List<int> clustersEnergy = new List<int> { };

        //--------- Energy consumption parameters ------------
        double E_fs = 0.01;//nJ(10^-9) amplifier energy, free space model (short distance) | d<d0
        double E_mp = 1300000; //nJ // multipath fading model (large distance) | d >= d0
        int E_elec = 50; //nJ, energy for work signal transmission/recieve
        int node_E = 500000000; //nJ; = 0,5J // initial node energy
        double d0 = 87.7; // (m) distance threshold for swapping amplification models
        //----------------------------------------------------

        public EnergyCalculator(Dictionary<Point, int> allNodes)
        {
            this.allNodes = allNodes;

            foreach (var node in allNodes)
                nodesLevelCharge.Add(node.Key, node_E);

            //d0 = Math.Sqrt(E_fs / E_mp);
        }

        public void CalculteAllNodesEnergy(Dictionary<Point, int> nodesClustered, List<Point> clusterCenters) {

            for (int i = 1; i < clusterCenters.Count; i++) {
                List<Point> cluster = Calculator.getCluster(i, nodesClustered);
                Start_DT_Protocol(cluster);



            }
        }

        public void Start_DT_Protocol(List<Point> cluster) { // direct transmission in cluster, calculate energy
            Point center = Calculator.findCentroid(cluster);
            foreach (Point point in cluster)
                PPConnection(point, center);
        }

        public int PPConnection(Point node, Point station) {
            //int len = Calculator.genRandInt(20, 65535); // bytes, package size
            int len = 4000;
            double dist = Calculator.calcDistance(node, station);
            Console.WriteLine("Distance: " + Math.Round(dist));
            if (dist >= d0)
                dist = Math.Pow(dist, 2);

            double E_transmission = len * E_elec + len * E_fs * Math.Pow(dist, 2);
            double E_receive = len * E_elec;
            Console.WriteLine(node + " " + station);
            Console.WriteLine("E: " + E_transmission + " -> " + E_receive);

            return 0;
        }


    }
}
