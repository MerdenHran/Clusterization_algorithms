using System;
using System.Collections.Generic;
using System.Drawing;

namespace Clusterization_algorithms
{
    class RouteBuilder
    {
        Point startPoint = new Point(0, 0);
        private List<Point> all_points = new List<Point> { }; // start point position
        private List<Point> routeList = new List<Point> { }; // finish point position
        private List<Point> convex_hull = new List<Point> { };
        private List<Point> inside_points = new List<Point> { };
        //private List<int> indexes = new List<int> { };

        //Brute-force
        private double length;

        public void All_points(List<Point> points)
        {
            all_points.Clear();
            all_points.AddRange(points);
        }
        public List<Point> Convex_hull { get => convex_hull; }
        public List<Point> RouteList { get => routeList; set => routeList = value; }

        public RouteBuilder()
        {
        }

        public List<Point> CalculateRouteByElasticNet()
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

            //findIndexes();

            //all_points.Clear();
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

        public List<Point> CalculateRouteBruteForce(List<Point> pointList)
        {
            List<Point> points = new List<Point> { };
            points.Add(startPoint);
            points.AddRange(pointList);
            points.Add(startPoint);

            //points = newPoints;

            length = 9999; // any value that is more then any possible length
            RecursivePermutation(1, points);

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

        public List<Point> CalculateRouteByNearestNeighbour(List<Point> pointList) {

            List<Point> points = new List<Point> { };
            points.AddRange(pointList);
            List<bool> pointIsUsed = new List<bool> {}; //false

            foreach (Point point in points) {
                pointIsUsed.Add(false);
            } 

            List<Point> route = new List<Point> { startPoint };
            Point current_point = startPoint;

            for (int j = 0; j < points.Count; j++)
            {
                int min_point_index = 0;
                double min_distance = 99999; // any large value

                for (int i = 0; i < points.Count; i++)
                {
                    if (!pointIsUsed[i])
                    {
                        double distance = Calculator.calcDistance(current_point, points[i]);

                        if (distance < min_distance)
                        {
                            min_distance = distance;
                            min_point_index = i;
                        }
                    }
                }

                current_point = points[min_point_index];
                pointIsUsed[min_point_index] = true;
                route.Add(current_point);
            }

            route.Add(startPoint);
            return route;
        }

        public List<Point> CalculateRouteByFPPWR(List<Point> pointList, int x_count, int y_count, double width, double heigth) {
            
            List<Point> points = new List<Point> { };
            points.AddRange(pointList);
            List<Point> route = new List<Point> { startPoint };

            // cell sides size
            double x_side = width / x_count;
            double y_side = heigth / y_count;

            //List<Point> previousCell = new List<Point> { }; // FPPWR feture (negative)

            for (int iy = 0; iy < y_count; iy++) {

                double y_up = y_side * iy;
                double y_down = y_side * (iy + 1);

                if (iy % 2 == 0) {
                    for (int ix = 0; ix < x_count; ix++) {

                        double x_left = x_side * ix;
                        double x_right = x_side * (ix + 1);
                        
                        List<Point> cell = GetCellPointList(points, x_left, x_right, y_up, y_down, route);
                        cell = Calculator.SortPointListByX(cell);

                            //FPPWR_Feature(cell, previousCell, route);

                        route.AddRange(cell);
                    }
                }
                else {
                    for (int ix = x_count; ix > 0; ix--) {

                        double x_right = x_side * ix;
                        double x_left = x_side * (ix - 1);

                        List<Point> cell = GetCellPointList(points, x_left, x_right, y_up, y_down, route);
                        cell = Calculator.SortPointListByX(cell);
                        cell.Reverse();

                            //FPPWR_Feature(cell, previousCell, route);

                        route.AddRange(cell);
                    }
                }
            }

            route.Add(startPoint);
            return route;
        }

        private List<Point> GetCellPointList(List<Point> points, double x_left, double x_rigth, double y_up, double y_down, List<Point> route) {

            List<Point> cell = new List<Point> { };

            foreach (Point point in points)
            {
                if ((point.X >= x_left) && (point.X) <= x_rigth)
                    if ((point.Y >= y_up) && (point.Y) <= y_down)
                        if (!route.Contains(point))
                            cell.Add(point);
            }
            return cell;
        }

        //private void FPPWR_Feature(List<Point> cell, List<Point> previousCell, List<Point> route) // FPPWR feture (negative)
        //{
        //    if (previousCell.Count != 0)
        //    {
        //        Point closerPoint = Calculator.FindCloserPoint(cell[0], previousCell);
        //        route.Remove(closerPoint);
        //        route.Add(closerPoint);
        //    }
        //    previousCell = cell;
        //}
    }
}
