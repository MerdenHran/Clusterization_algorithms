using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clusterization_algorithms
{
    /// <summary>
    /// Weighed random with points to k-means++ algorithm
    /// Need to set start position to seeds autimatically and optimaly
    /// </summary>
    class SeedGenerator
    {
        private Dictionary<Point, double> points = new Dictionary<Point, double> { }; // <point, weight>; Weight = Distance
        public int seedCount = 2;
        private Random rand = new Random();
        private List<Point> seeds = new List<Point> { };
        private double sumOfWeigh = 0;

        public SeedGenerator()
        {
        }

        public SeedGenerator(Dictionary<Point, int> points, int seedCount)
        {
            SetPoints(points);
            this.seedCount = seedCount;
        }

        public List<Point> GetSeeds()
        { // CALL THIS METHOD TO START!!!

            int rnum = rand.Next(0, points.Count - 1);
            Point seed1 = points.ElementAt(rnum).Key; // get 1-st random seed from points
            seeds.Add(seed1);                         // add point to seed list
            points.Remove(seed1);                     // remove this point from points
            Console.WriteLine("1-st seed: " + seed1.ToString() + '\n');

            calculatePointsWeight(seed1);

            for (int i = 1; i < seedCount; i++)
                findNewSeed();

            return seeds;
        }

        private void findNewSeed()
        { // !!!
            SortPoints();

            Console.WriteLine("Sum of weigth: " + sumOfWeigh);

            double rsum = rand.Next(0, (int)sumOfWeigh);
            Console.WriteLine("Random sum: " + rsum + '\n');

            for (int i = 0; i < points.Count; i++)
            {

                var pair = points.ElementAt(i);

                if (pair.Value >= rsum)
                {
                    seeds.Add(pair.Key);
                    points.Remove(pair.Key);
                    calculatePointsWeight(pair.Key);

                    Console.WriteLine("new seed: " + pair.Key);
                    break;
                }

                rsum -= pair.Value;
                //Console.WriteLine(rsum);
            }

            Console.WriteLine();
            printSeeds();
        }

        private void SortPoints()
        {
            Dictionary<Point, double> newPoints = new Dictionary<Point, double> { };

            foreach (var pair in points.OrderBy(ppair => ppair.Value))
            {
                newPoints.Add(pair.Key, pair.Value);
            }
            points = newPoints;
            printPoints();
        }

        private void calculatePointsWeight(Point seed)
        {

            Dictionary<Point, double> newPoints = new Dictionary<Point, double> { };
            sumOfWeigh = 0;

            for (int i = 0; i < points.Count; i++)
            {

                Point point = points.ElementAt(i).Key;
                double weigh = points.ElementAt(i).Value;

                double dist = Calculator.calcDistance(seed, point);
                weigh += dist;
                sumOfWeigh += weigh;

                newPoints.Add(point, weigh);
            }
            points = newPoints;
            //printPoints();
        }

        public void SetPoints(Dictionary<Point, int> dictionary)
        {
            foreach (var pair in dictionary)
            {
                points.Add(pair.Key, 0);
            }
        }

        public String printPoints()
        {
            String str = "";

            Console.WriteLine("Points list:");

            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
                str += point.ToString() + "\n";
            }
            Console.WriteLine();
            return str;
        }

        public void printSeeds()
        {
            Console.WriteLine("Print seeds:");
            foreach (Point seed in seeds)
            {
                Console.WriteLine(seed.ToString());
            }
            Console.WriteLine();
        }
    }
}
