using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clusterization_algorithms
{
    /// <summary>
    /// Class calculate math operations and print data. Call without creating object.
    /// </summary>
    class Calculator
    {

        // find points center | centroid | barycenter | mass center
        public static Point findCentroid(List<Point> pointGroup)
        {
            int x = 0;
            int y = 0;

            //printList(pointGroup);

            for (int i = 0; i < pointGroup.Count; i++)
            {
                x += pointGroup.ElementAt(i).X;
                y += pointGroup.ElementAt(i).Y;
            }

            x = x / pointGroup.Count;
            y = y / pointGroup.Count;

            Point point = new Point(x, y);
            //Console.WriteLine("FindBarycenter return: " + point);

            return point;
        }

        // distance between A and B points
        public static double calcDistance(Point a, Point b)
        {
            int delX = (int)Math.Pow(b.X - a.X, 2);
            int delY = (int)Math.Pow(b.Y - a.Y, 2);
            double distance = Math.Sqrt(delX + delY); // distance between points

            //Console.WriteLine("distance between " + a + " " + b + " = " + distance);
            return distance;
        }

        // generate random points and add them to the dictionary
        public static Dictionary<Point, int> generatePoints(int count, int rangeX, int rangeY)
        {
            Random rand = new Random();

            //Console.WriteLine("#generatePoints");

            Dictionary<Point, int> points = new Dictionary<Point, int>();

            for (int i = 0; i < count; i++)
            {
                Point point = new Point(rand.Next(rangeX), rand.Next(rangeY));
                points.Add(point, 0);

                //Console.WriteLine(point.ToString());
            }
            return points;
        }

        public static String printPoints(Dictionary<Point, int> points)
        {
            String str = "";

            //Console.WriteLine("\nPoints list:");

            foreach (var point in points)
            {
                //Console.WriteLine(point.ToString());
                str += point.ToString() + "\n";
            }
            //Console.WriteLine();
            return str;
        }
    }
}
