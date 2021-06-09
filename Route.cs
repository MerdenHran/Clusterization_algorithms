using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Clusterization_algorithms
{
    class Route
    {
        Point startPoint = new Point(0, 0);
        private List<Point> routeList = new List<Point> { };
        private List<Point> convex_hull = new List<Point> { };
        private List<Point> inside_points = new List<Point> { };
        private List<Point> all_points = new List<Point> { };

        public List<Point> All_points
        {
            set => all_points.AddRange(value);
        }
        public List<Point> RouteList { get => routeList; }

        public Route()
        {
        }

        public List<Point> CalculateRoute()
        {
            routeList.Clear();
            convex_hull.Clear();
            inside_points.Clear();

            JarvisMarch();
            ElasticNet();

            List<Point> unsort_route = new List<Point> { };
            unsort_route.AddRange(routeList);
            routeList.Clear();

            SortInsidePoints(); // sort points inside convex hull by they mass center
            ElasticNet();

            double unsort_route_length = Calculator.calcRouteLength(unsort_route);
            double sort_route_length = Calculator.calcRouteLength(routeList);

            Console.WriteLine("Unsort route length: " + unsort_route_length);
            Console.WriteLine("Sort route length:   " + sort_route_length);

            if (unsort_route_length < sort_route_length)
            {
                routeList.Clear();
                routeList.AddRange(unsort_route);
                Console.WriteLine("UNSORTED");
            }

            all_points.Clear();
            return routeList;
        }

        public List<Point> ElasticNet()
        {

            routeList.AddRange(convex_hull);

            for (int i = 0; i < inside_points.Count; i++)
            {
                double minDist = CalcABC_Dist(routeList[0], inside_points[i], routeList[1]); // значення змінних при j = 0 в циклі
                int pos = 0; // first selected position in route

                for (int j = 1; j < routeList.Count - 1; j++)
                {

                    double dist = CalcABC_Dist(routeList[j], inside_points[i], routeList[j + 1]);

                    if (dist >= minDist)
                    {
                        minDist = dist;
                        pos = j;
                    }
                }
                AddToRouteAtPos(pos + 1, inside_points[i]);
            }
            return routeList;
        }

        private void AddToRouteAtPos(int position, Point point)
        { // write point at the selected position in route

            List<Point> newRoute = new List<Point> { };

            for (int i = 0; i < routeList.Count; i++)
            {

                if (i == position)
                    newRoute.Add(point);

                newRoute.Add(routeList[i]);
            }
            routeList.Clear();
            routeList.AddRange(newRoute);
        }

        private double CalcABC_Dist(Point a, Point b, Point c)
        { // a -> b -> c // ...,a,c,...- route, b - write in route
            double cos = Calculator.FindCOS(a, b, c);
            return cos;
        }

        public void JarvisMarch()
        {

            List<Point> points = new List<Point> { };
            points.AddRange(all_points);

            Point falsePoint = new Point(startPoint.X - 1, startPoint.Y); // точка прямої(вектора) для початку обгортки (проти часової стрілки)
            // положення осей координат -> ↓(Y) →(X)
            convex_hull.Add(startPoint);
            convex_hull.Add(falsePoint);

            Point point = points[0];
            points.Add(startPoint);
            int k = 0;

            do
            {
                double max_cos = -1; // cos(0°...90°...180°) = 1...0...-1 
                Point nextPoint = startPoint;

                for (int i = 0; i < points.Count; i++)
                { // where cos is min that point is next

                    double cos = Calculator.FindCOS(convex_hull[k], convex_hull[k + 1], points[i]); // шукаємо косинус кута між векторами
                                                                                                    //Console.WriteLine("cos = " + cos);

                    if (cos > max_cos)
                    { // чим менший cos тим більший кут () між векторами
                        max_cos = cos;
                        nextPoint = points[i];
                    }
                }

                point = nextPoint;
                k++;
                points.Remove(nextPoint);
                convex_hull.Add(nextPoint);

            } while (point != startPoint);

            convex_hull.Remove(falsePoint);
            inside_points.AddRange(points);
        }

        private void SortInsidePoints()
        { // sort inside points by mass center // [спростити, переробити]
            Point center = Calculator.findCentroid(all_points);
            List<Point> sortedList = new List<Point> { };
            Dictionary<Point, double> dict = new Dictionary<Point, double> { };

            for (int i = 0; i < inside_points.Count; i++)
            {
                double dist = Calculator.calcDistance(center, inside_points[i]);
                dict.Add(inside_points[i], dist);
            }

            List<KeyValuePair<Point, double>> myList = dict.ToList();
            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            for (int i = myList.Count - 1; i >= 0; i--)
            {
                sortedList.Add(myList[i].Key);
            }

            inside_points.Clear();
            inside_points.AddRange(sortedList);
        }
    }
}
