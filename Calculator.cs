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
    }
}
