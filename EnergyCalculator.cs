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
        Dictionary<Point, double> nodesLevelCharge;

        //--------- Energy consumption parameters ------------
        double E_amp;// amplifier energy
        int E_tx, E_rx, E_da, maxNodeCharge;
        //----------------------------------------------------

        public EnergyCalculator(Dictionary<Point, int> allNodes)
        {
            this.allNodes = allNodes;

            foreach (var node in allNodes)
                nodesLevelCharge.Add(node.Key, 100); // 100% charge

            E_amp = 0.0013; // amplifier energy
            E_tx = 50; // (nJ) (1nJ = 10 pow -9 J) energy for signal transmission
            E_rx = 50; // (nJ), energy to receive the signal
            E_da = 5; // (nJ), energy for 1 bit data
            maxNodeCharge = 12960; // (J); U=3,6V; Q=3600(C); C=Q/U=1000F
        }

        public void CalculteAllNodesEnergy(Dictionary<Point, int> nodesClustered, List<Point> clusterCenters) {

            for (int i = 1; i <= clusterCenters.Count; i++) {
                List<Point> cluster = Calculator.getCluster(i, nodesClustered);




            }
        }

        public void Start_DT(List<Point> cluster, Point center) { // direct transmission in cluster, find energy
            
        }
        



    }
}
