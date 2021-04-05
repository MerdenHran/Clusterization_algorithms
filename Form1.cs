using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clusterization_algorithms
{
    public partial class Form1 : Form
    {
        Forel forel;
        Graphic graphic;
        List<Point> points;

        public Form1()
        {
            InitializeComponent();
            Graphics graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);
            forel = new Forel(graphic);
        }

        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);

            if(!Int32.TryParse(textBoxSetPointsCount.Text, out int pointsCount))
                pointsCount = 20;

            //points = Calculator.setStaticPoints();
            //forel.setPoints(points);

            forel.setPoints(Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height));
            textBoxInfo.Text = Calculator.printPoints(forel.getPoints());
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            forel.Radius = 150;

            if (Int32.TryParse(textBoxSetRadius.Text, out int radius))
                forel.Radius = radius;

            forel.startForel();
            textBoxInfo.Text = Calculator.printPoints(forel.getPoints());
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            pictBoxArea.Image = null;
            textBoxInfo.Clear();

            forel.clearFields();
        }

        private void btnKMeans_Click(object sender, EventArgs e)
        {
            // <1> set seeds
            // <2> start calculate
        }
    }
}
