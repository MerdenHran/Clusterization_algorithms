using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace Clusterization_algorithms
{
    class K_means
    {
        /* Dictionary contain all pairs (point, number_of_cluster),
        * if (cluster = 0) => point not belong to cluster*/
        private Dictionary<Point, int> points = new Dictionary<Point, int>();
        private List<Point> seeds;
        private Graphic graphic;

        public List<Point> Seeds { get => seeds; set => seeds = value; }

        public void setPoints(Dictionary<Point, int> pointDictionary) {
            points.Clear();

            foreach (KeyValuePair<Point, int> point in pointDictionary)
            {
                points.Add(point.Key, point.Value);
            }
        }

        public K_means()
        {
        }

        public K_means(Graphic graphic)
        {
            this.graphic = graphic;
        }

        public Dictionary<Point, int> getPoints()
        {
            return points;
        }

        public void DrawSeeds() {
            foreach (Point seed in seeds)
                graphic.DrawPoint(seed, Brushes.Red);
        }

        //write select point to cluster
        private void AddToCluster(KeyValuePair<Point, int> point, int clusterNum) {
            points.Remove(point.Key);
            points.Add(point.Key, clusterNum);

            //graphic.D
            Calculator.printPoints(points);
        }

        private void FindAllClusters() {

            for (int i = 0; i < points.Count; i++) {

                double distance = 99999;
                int closerSeedNum = 0;
                KeyValuePair<Point, int> point = points.ElementAt(i);

                for (int j = 0; j < seeds.Count; j++) {

                    double dist = Calculator.calcDistance(point.Key, seeds.ElementAt(j));

                    if (dist < distance) {
                        distance = dist;
                        closerSeedNum = j + 1;
                    }
                }

                AddToCluster(point, closerSeedNum);
                graphic.DrawLine(seeds.ElementAt(closerSeedNum - 1), point.Key, Color.LightGreen);
            }
        }

        private Boolean FindCentroids() {
            List<Point> centroids = new List<Point> { };

            for (int i = 0; i < seeds.Count; i++) {

                List<Point> pointList = new List<Point> { };

                foreach (KeyValuePair<Point, int> pair in points) {
                    if (i + 1 == pair.Value)
                        pointList.Add(pair.Key);
                }

                Point centroid = Calculator.findCentroid(pointList);
                centroids.Add(centroid);
            }

            if (!isEqualSeed(centroids))
                seeds = centroids;
            else return false;

            return true;
        }

        public void startK_means() { //

            graphic.DrawPointDictionary(points);
            DrawSeeds();
            FindAllClusters();
            
            if (FindCentroids()) {
                Thread.Sleep(1000);
                graphic.ClearImage();
                startK_means();
            }
            DrawSeeds();
        }

        private Boolean isEqualSeed(List<Point> list) {
            for (int i = 0; i < seeds.Count; i++) {
                if (seeds.ElementAt(i) != list.ElementAt(i))
                    return false;
            }
            return true;
        }
    }
}
