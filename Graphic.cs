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

        private void PAUSE() {
            Thread.Sleep(500); // set this value to set drawing speed
        }

        public void DrawLine(Point p1, Point p2)
        {
            Pen pen = new Pen(Color.Green);
            pen.Width = 3;
            graphics.DrawLine(pen, p1, p2);
        }

        public void DrawCircle(Point p, int radius)
        {
            //Console.WriteLine("#DrawCircle " + p);
            graphics.DrawEllipse(greyPen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            PAUSE();
        }

        public void DrawFinalCircle(Point p, int radius)
        {
            //Console.WriteLine("#DrawCircle " + p);
            graphics.DrawEllipse(blackPen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            PAUSE();
        }

        public void DrawPoint(Point p)
        {
            Brush brush = (Brush)Brushes.Black;
            graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
        }

        public void DrawCentroid(Point p)
        {
            Brush brush = (Brush)Brushes.Red;
            graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
        }



        public void DrawPointArray(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                DrawPoint(points[i]);
            }
        }

        public void DrawPointDictionary(Dictionary<Point, int> points)
        {
            foreach (KeyValuePair<Point, int> result in points)
                DrawPoint(result.Key);
        }

        public void ClearImage() {
            graphics.Clear(Color.White);
        }

        public void RouteDrow(List<Tuple<Point, Point, double>> tuples)
        {
            for (int i = 0; i < tuples.Count; i++)
            {
                DrawLine(tuples[i].Item1, tuples[i].Item2);
            }

        }
    }
}
