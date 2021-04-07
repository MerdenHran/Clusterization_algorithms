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

        public static List<Point> listOfClastersCenter = new List<Point>();
        public static List<Tuple<Point, Point, double>> list_of_min_connects = new List<Tuple<Point, Point, double>>();

        public int Radius { get => radius; set => radius = value; }

        public Forel()
        {
        }

        public Forel(Graphic graphic)
        {
            this.graphic = graphic;
        }

        public void setPoints(Dictionary<Point, int> pointDictionary)
        {
            points = pointDictionary;
            //graphic.DrawPointDictionary(pointDictionary);
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

            if (cluster.Count == 0){ // if cluster no have elements, new_center = center
                
                graphic.DrawFinalCircle(center, radius);
                listOfClastersCenter.Add(center);
                return center;
            }

            //Point newCenter = findBarycenter(cluster);
            Point newCenter = Calculator.findCentroid(cluster);
            graphic.DrawCentroid(newCenter);
            graphic.DrawCircle(newCenter, radius);

            if (center == newCenter){

                graphic.DrawFinalCircle(center, radius);
                listOfClastersCenter.Add(center);
            }
                
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
            listOfClastersCenter.Clear();
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

        public void rem_Eq_Conn(List<Tuple<Point, Point, double>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].Item3 == list[j].Item3) list.RemoveAt(j);
                }
            }
        }
        
        public List<Tuple<Point, Point, double>> search_min_conn(List<Tuple<Point, Point, double>> tuples)
        {
            List<Tuple<Point, Point, double>> templist = new List<Tuple<Point, Point, double>>();

            Tuple<Point, Point, double> min_1_Conn = Tuple.Create(new Point(), new Point(), Double.MaxValue);
 
            for (int i = 0; i < listOfClastersCenter.Count; i++)
            {
                for (int j = 0; j < tuples.Count; j++)
                {
                    if(listOfClastersCenter[i] == tuples[j].Item1)
                    {
                        if (min_1_Conn.Item3 > tuples[j].Item3)
                        {
                            min_1_Conn = Tuple.Create(tuples[j].Item1, tuples[j].Item2, tuples[j].Item3);
                        }
                    }
                }
                templist.Add(min_1_Conn);
                min_1_Conn = Tuple.Create(new Point(), new Point(), Double.MaxValue);
            }

            return templist;
        }
        public List<Tuple<Point, Point, double>> drawRoute()
        {
            List<Tuple<Point, Point, double>> list_of_min_connects = new List<Tuple<Point, Point, double>>();

            List<Tuple<Point, Point, double>> listOfConnects = new List<Tuple<Point, Point, double>>(); // 
            for (int i = 0; i < listOfClastersCenter.Count; i++)
            {
                for (int j = 0; j < listOfClastersCenter.Count; j++)
                {
                    if (i == j) continue;
                    listOfConnects.Add(Tuple.Create(listOfClastersCenter[i], listOfClastersCenter[j], Calculator.calcDistance(listOfClastersCenter[i], listOfClastersCenter[j])));
                }
            }
            //rem_Eq_Conn(listOfConnects);

            //list_of_min_connects = search_min_conn(listOfConnects);

            for (int i = 0; i < listOfConnects.Count; i++)
            {
                if(listOfConnects[i].Item3 < radius * 2)
                {
                    list_of_min_connects.Add(listOfConnects[i]);
                }
            }

            return list_of_min_connects;
        }
    }
}
