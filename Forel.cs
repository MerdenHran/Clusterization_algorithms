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
        private Random rand = new Random();
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

        // generate random points and add them to the dictionary
        public void generatePoints(int count, int rangeX, int rangeY)
        {
            for (int i = 0; i < count; i++)
            {
                Point point = new Point(rand.Next(rangeX), rand.Next(rangeY));
                points.Add(point, 0);
                graphic.DrawPoint(point);
            }
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

        public String printPoints()
        {
            String str = "";

            Console.WriteLine("\nPoints list:");

            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
                str += point.ToString() + "\n";
            }
            Console.WriteLine();
            return str;
        }

        // distance between A and B points
        private double calcDistance(Point a, Point b)
        {
            Console.WriteLine("#CalculateDistance");

            int delX = (int)Math.Pow(b.X - a.X, 2);
            int delY = (int)Math.Pow(b.Y - a.Y, 2);
            double distance = Math.Sqrt(delX + delY); // distance between points

            Console.WriteLine("distance between " + a + " " + b + " = " + distance);

            return distance;
        }


        //write select point to cluster
        private void addToCluster(Point key)
        {
            Console.WriteLine("#AddToCluster");
            points.Remove(key);
            points.Add(key, clusterNum);

            Console.WriteLine("Add point " + key + " to cluster " + clusterNum);

            printPoints();
        }

        // write points in list to cluster
        private void addPointsToCluster(List<Point> pointsList)
        {
            Console.WriteLine("#AddPointsToCluster");
            printList(pointsList);
            foreach (Point point in pointsList)
            {
                addToCluster(point);
            }
        }

        // find points center | centroid | barycenter | mass center
        private Point findBarycenter(List<Point> pointGroup)
        {
            Console.WriteLine("#FindBarycenter");

            int x = 0;
            int y = 0;

            printList(pointGroup);

            for (int i = 0; i < pointGroup.Count; i++)
            {
                x += pointGroup.ElementAt(i).X;
                y += pointGroup.ElementAt(i).Y;
            }

            x = x / pointGroup.Count;
            y = y / pointGroup.Count;

            Point point = new Point(x, y);
            Console.WriteLine("FindBarycenter return: " + point);

            graphic.DrawRedPoint(point);
            graphic.DrawCircle(point, radius);

            return point;
        }

        // get cluster from center coordinates
        private List<Point> getCluster(Point center)
        {
            Console.WriteLine("#GetCluster");

            List<Point> cluster = new List<Point> { };

            for (int i = 0; i < points.Count; i++)
            {

                if (points.ElementAt(i).Value == 0)
                {
                    double distance = calcDistance(center, points.ElementAt(i).Key);

                    if (distance <= radius)
                        cluster.Add(points.ElementAt(i).Key);
                }
            }

            Console.WriteLine();

            Console.WriteLine("<< GetCluster return cluster list");
            printList(cluster);
            return cluster;
        }

        // find new centroid (mass center)
        private Point findNewCenter(Point center)
        {
            Console.WriteLine("#FindNewCenter");

            List<Point> cluster = getCluster(center);

            if (cluster.Count == 0)
            { // if cluster no have elements, new_center = center
                graphic.DrawFinalCircle(center, radius);
                return center;
            }

            Point newCenter = findBarycenter(cluster);
            Console.WriteLine("<< FindNewCenter return " + newCenter);

            if (center == newCenter)
                graphic.DrawFinalCircle(center, radius);

            return newCenter;
        }

        //start clusters searching process
        private Point clusterisation(Point center)
        {
            Console.WriteLine("#Clusterisation");
            Point newCenter = findNewCenter(center);
            Console.WriteLine(newCenter);

            if (newCenter != center)
                clusterisation(newCenter);
            else
                addPointsToCluster(getCluster(newCenter));

            Console.WriteLine("<< Clusterization return " + center);
            return newCenter;
        }


        // THIS METHOD RUN FOREL ALGORITHM
        public void startForel()
        {
            Console.WriteLine("#StartForel");

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
            Console.WriteLine("#ClearFields");
            clusterNum = 0;
            points.Clear();
        }

        // print formatted to TextBox
        private void printList(List<Point> list)
        {

            Console.WriteLine("Print point list:");
            int counter = 1;

            foreach (Point p in list)
            {
                Console.Write(p + " ");
                if (counter % 10 == 0)
                    Console.WriteLine();
                counter++;
            }
        }
    }
}
