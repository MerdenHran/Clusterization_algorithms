using System;
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

        private void PAUSE(int pause) {
            pause = 100;
            Thread.Sleep(pause); // set this value to set drawing speed
        }

        public void DrawLine(Point p1, Point p2, Color color)
        {
            Pen pen = new Pen(color);
            pen.Width = 3;
            graphics.DrawLine(pen, p1, p2);
        }

        public void DrawCircle(Point p, int radius, Color color)
        {
            Pen pen = new Pen(color);
            pen.Width = 2;
            graphics.DrawEllipse(pen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            PAUSE(100);
        }

        public void DrawPoint(Point p, Brush brush)
        {
            graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
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

        public void ClearImage() {
            graphics.Clear(Color.White);
        }

        public void DrawRoute(List<Point> points)
        {
            for (int i = 1; i < points.Count; i++) {
                DrawLine(points[i - 1], points[i], Color.Orange);
                PAUSE(100);
            }
        }
    }
}
