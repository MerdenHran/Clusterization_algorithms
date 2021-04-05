using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Clusterization_algorithms
{
    class Forel
    {
        /* Dictionary contain all pairs (point, number_of_cluster),
         * if (cluster = 0) => point not belong to cluster*/
        private Dictionary<Point, int> points = new Dictionary<Point, int>();
        private int clusterNum = 0;
        private int radius; // search radius
        private Graphic graphic;

        public int Radius { get => radius; set => radius = value; }

        public Forel()
        {
        }

        public Forel(Graphic graphic)
        {
            this.graphic = graphic;
        }

        public Forel(int radius, Graphic graphic)
        {
            this.radius = radius;
            this.graphic = graphic;
        }

        //set starting custer value (0) for all points in list
        public void setPoints(List<Point> pointList)
        {
            for (int i = 0; i < pointList.Count; i++)
            {
                points.Add(pointList.ElementAt(i), 0);
                graphic.DrawPoint(pointList.ElementAt(i));
            }
        }

        public void setPoints(Dictionary<Point, int> pointDictionary)
        {
            points = pointDictionary;
            graphic.DrawPointDictionary(pointDictionary);
        }

        public Dictionary<Point, int> getPoints() {
            return points;
        }

        //write select point to cluster
        private void addToCluster(Point key)
        {
            //Console.WriteLine("#AddToCluster");
            points.Remove(key);
            points.Add(key, clusterNum);

            //Console.WriteLine("Add point " + key + " to cluster " + clusterNum);

            Calculator.printPoints(points);
        }

        // write points in list to cluster
        private void addPointsToCluster(List<Point> pointsList)
        {
            //Console.WriteLine("#AddPointsToCluster");
            foreach (Point point in pointsList)
            {
                addToCluster(point);
            }
        }

        // get cluster from center coordinates
        private List<Point> getCluster(Point center)
        {
            //Console.WriteLine("#GetCluster");

            List<Point> cluster = new List<Point> { };

            for (int i = 0; i < points.Count; i++)
            {

                if (points.ElementAt(i).Value == 0)
                {
                    double distance = Calculator.calcDistance(center, points.ElementAt(i).Key);

                    if (distance <= radius)
                        cluster.Add(points.ElementAt(i).Key);
                }
            }

            //Console.WriteLine();
            //Console.WriteLine("<< GetCluster return cluster list");
            return cluster;
        }

        // find new centroid (mass center)
        private Point findNewCenter(Point center)
        {
            List<Point> cluster = getCluster(center);

            if (cluster.Count == 0)
            { // if cluster no have elements, new_center = center
                graphic.DrawFinalCircle(center, radius);
                return center;
            }

            //Point newCenter = findBarycenter(cluster);
            Point newCenter = Calculator.findCentroid(cluster);
            graphic.DrawRedPoint(newCenter);
            graphic.DrawCircle(newCenter, radius);

            if (center == newCenter)
                graphic.DrawFinalCircle(center, radius);

            return newCenter;
        }

        //start clusters searching process
        private Point clusterisation(Point center)
        {
            //Console.WriteLine("#Clusterisation");
            Point newCenter = findNewCenter(center);
            //Console.WriteLine(newCenter);

            if (newCenter != center)
                clusterisation(newCenter);
            else
                addPointsToCluster(getCluster(newCenter));

            //Console.WriteLine("<< Clusterization return " + center);
            return newCenter;
        }


        // THIS METHOD RUN FOREL ALGORITHM
        public void startForel()
        {
            //Console.WriteLine("#StartForel");

            for (int i = 0; i < points.Count; i++)
            {

                if (points.ElementAt(i).Value == 0)
                {
                    clusterNum++;
                    clusterisation(points.ElementAt(i).Key);
                }
            }
        }

        // reset data
        public void clearFields()
        {
            //Console.WriteLine("#ClearFields");
            clusterNum = 0;
            points.Clear();
        }
    }
}
