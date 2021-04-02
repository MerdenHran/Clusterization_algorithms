using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Clusterization_algorithms
{
    class Graphic
    {
        private Graphics graphics;
        private Pen blackPen = new Pen(Color.Black);
        private Pen greyPen = new Pen(Color.Gray);

        public Graphic(Graphics graphics)
        {
            this.graphics = graphics;
            blackPen.Width = 2;
        }

        public Graphic()
        {
        }

        public void DrawLine(Point p1, Point p2)
        {
            graphics.DrawLine(blackPen, p1, p2);
        }

        public void DrawCircle(Point p, int radius)
        {
            Console.WriteLine("#DrawCircle " + p);
            graphics.DrawEllipse(greyPen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            Thread.Sleep(500);
        }

        public void DrawFinalCircle(Point p, int radius)
        {
            Console.WriteLine("#DrawCircle " + p);
            graphics.DrawEllipse(blackPen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            Thread.Sleep(500);
        }

        public void DrawPoint(Point p)
        {
            Brush brush = (Brush)Brushes.Black;
            graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
        }

        public void DrawRedPoint(Point p)
        {
            Brush brush = (Brush)Brushes.Red;
            graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
            Thread.Sleep(500);
        }

        public void DrawPointArray(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                DrawPoint(points[i]);
            }
        }
        public void RouteDrow(List<Tuple<Point, Point, double>> tuples)
        {
            for (int i = 0; i < tuples.Count; i++)
            {
                DrawLine(tuples[i].Item1, tuples[i].Item2);
                tuples.RemoveAt(i);
            }
        }
    }
}
