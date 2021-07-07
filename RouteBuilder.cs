using System.Collections.Generic;
using System.Drawing;

namespace Clusterization_algorithms
{
    class RouteBuilder
    {
        Point startPoint = new Point(0, 0);
        private List<Point> routeList = new List<Point> { };
        private List<Point> convex_hull = new List<Point> { };
        private List<Point> inside_points = new List<Point> { };
        private List<Point> all_points = new List<Point> { };

        //Brute-force
        private double length;

        public void All_points(List<Point> points)
        {
            all_points.Clear();
            all_points.AddRange(points);
        }
        public List<Point> RouteList { get => routeList; }
        public List<Point> Convex_hull { get => convex_hull; }

        public RouteBuilder()
        {
        }

        public List<Point> CalculateRoute()
        {
            JarvisMarch();
            ElasticNet();

            List<Point> unsort_route = new List<Point> { };
            unsort_route.AddRange(routeList);
            routeList.Clear();

            SortInsidePoints(); // sort points inside convex hull by they mass center
            ElasticNet();

            double unsort_route_length = Calculator.calcRouteLength(unsort_route);
            double sort_route_length = Calculator.calcRouteLength(routeList);

            //Console.WriteLine("Unsort route length: " + unsort_route_length);
            //Console.WriteLine("Sort route length:   " + sort_route_length);

            if (unsort_route_length < sort_route_length)
            {
                routeList.Clear();
                routeList.AddRange(unsort_route);
                //Console.WriteLine("UNSORTED");
            }

            all_points.Clear();
            return routeList;
        }

        private List<Point> ElasticNet()
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

        public void JarvisMarch(bool getSpiralRoute = false) // 
        {
            routeList.Clear();
            convex_hull.Clear();
            inside_points.Clear();

            List<Point> points = new List<Point> { };
            points.AddRange(all_points);

            Point falsePoint = new Point(startPoint.X - 1, startPoint.Y); // точка прямої(вектора) для початку обгортки (проти часової стрілки)
            // положення осей координат -> ↓(Y) →(X)
            convex_hull.Add(startPoint);
            convex_hull.Add(falsePoint);

            Point point = points[0];
            
            if(!getSpiralRoute)
                points.Add(startPoint);
            int ki = 0;

            do
            {
                double max_cos = -1; // cos(0°...90°...180°) = 1...0...-1 
                Point nextPoint = startPoint;

                for (int i = 0; i < points.Count; i++)
                { // where cos is min that point is next
                    double cos = Calculator.FindCOS(convex_hull[ki], convex_hull[ki + 1], points[i]); // шукаємо косинус кута між векторами
                                                                                                    //Console.WriteLine("cos = " + 
                    if (cos > max_cos)
                    { // чим менший cos тим більший кут () між векторами
                        max_cos = cos;
                        nextPoint = points[i];
                    }
                }

                point = nextPoint;
                ki++;
                points.Remove(nextPoint);
                convex_hull.Add(nextPoint);

            } while ((point != startPoint));

            convex_hull.Remove(falsePoint);
            inside_points.AddRange(points);
        }

        private void SortInsidePoints() // rework later
        { 
            Point center = Calculator.findCentroid(all_points);
            Dictionary<Point, double> dict = new Dictionary<Point, double> { };

            for (int i = 0; i < inside_points.Count; i++)
            {
                double dist = Calculator.calcDistance(center, inside_points[i]);
                dict.Add(inside_points[i], dist);
            }

            dict = Calculator.sortDictionaryByValue(dict);

            inside_points.Clear();
            inside_points.AddRange(Calculator.DictionaryToList(dict));
        }

        public List<Point> CalculateRouteBruteForce(List<Point> points)
        {
            List<Point> newPoints = new List<Point> { };
            newPoints.Add(startPoint);
            newPoints.AddRange(points);
            newPoints.Add(startPoint);

            points = newPoints;

            length = 9999999;
            RecursivePermutation(1, newPoints);

            return routeList;
        }

        private void RecursivePermutation(int startPos, List<Point> points) // first and last fixed
        {
            int size = points.Count;

            if (startPos == size - 1)
            {
                double newLength = Calculator.calcRouteLength(points);
                if (newLength < length)
                {
                    length = newLength;
                    routeList.Clear();
                    routeList.AddRange(points);
                }
            }
            else
            {
                for (int j = startPos; j < size - 1; ++j)
                {
                    swap(startPos, j, points);
                    startPos++;
                    RecursivePermutation(startPos, points);
                    startPos--;
                    swap(startPos, j, points);
                }
            }
        }

        private void swap(int pos_1, int pos_2, List<Point> points)
        {
            Point point = points[pos_1];
            points[pos_1] = points[pos_2];
            points[pos_2] = point;
        }
    }
}
