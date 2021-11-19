using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Clusterization_algorithms
{
    class Graphic
    {
        private Graphics graphics;

        public Graphic(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Graphic()
        {
        }

        public void PAUSE(int pause = 100) {
            Thread.Sleep(pause); // set this value to set drawing speed
        }

        public void DrawLine(Point p1, Point p2, Color color)
        {
            Pen pen = new Pen(color);
            pen.Width = 3;
            graphics.DrawLine(pen, p1, p2);
        }

        public void DrawCircle(Point p, int radius, Color color, int pause = 30)
        {
            Pen pen = new Pen(color);
            pen.Width = 2;
            graphics.DrawEllipse(pen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            PAUSE(pause);
        }

        public void DrawPoint(Point p, Brush brush, int size = 4)
        {
            int s = (int)(size/2);
            //graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
            graphics.FillRectangle(brush, p.X - s, p.Y - s, size, size);
        }

        public void DrawPointArray(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                DrawPoint(points[i], Brushes.Black);
            }
        }

        public void DrawPointDictionary(Dictionary<Point, int> points)
        {
            foreach (KeyValuePair<Point, int> result in points)
                DrawPoint(result.Key, Brushes.Black);
        }

        public void DrawPointList(List<Point> points)
        {
            foreach (Point point in points)
                DrawPoint(point, Brushes.Black);
        }

        public void ClearImage() {
            graphics.Clear(Color.White);
        }

        public void DrawRoute(List<Point> points, Color color, int pause = 10)
        {
            for (int i = 1; i < points.Count; i++) {
                DrawLine(points[i - 1], points[i], color);
                PAUSE(pause);
            }
        }

        public void DrawNet(int x_count, int y_count, double width, double heigth) {

            // cell sides size
            double x_side = width / x_count;
            double y_side = heigth / y_count;

            // draw horisontal lines
            for (int ix = 0; ix <= x_count; ix++)
            {
                int x_position = (int) (x_side * ix);
                Point pointUp = new Point(x_position, 0);
                Point pointDown = new Point(x_position, (int)heigth);
                
                DrawLine(pointUp, pointDown, Color.DarkGray);
            }

            // draw vertical lines
            for (int iy = 0; iy <= x_count; iy++)
            {
                int y_position = (int)(y_side * iy);
                Point pointLeft = new Point(0, y_position);
                Point pointRight = new Point((int)width, y_position);

                DrawLine(pointLeft, pointRight, Color.DarkGray);
            }

        }
    }
}
