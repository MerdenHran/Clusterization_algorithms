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
        Graphic graphic;
        Forel forel;
        K_means k_means;
        Dictionary<Point, int> points;

        public Form1()
        {
            InitializeComponent();
            Graphics graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);

            forel = new Forel(graphic);
            k_means = new K_means(graphic);
            //MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        //public int x, y;
        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    x = MousePosition.X;
        //    y = MousePosition.Y;
        //    textBox2.Text = "X = " + x.ToString() + ";  Y + " + y.ToString();   //или textBox1.Text   
        //}


        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);

            if(!Int32.TryParse(textBoxSetPointsCount.Text, out int pointsCount))
                pointsCount = 20;

            points = Calculator.setStaticPoints();
            //points = Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);
            graphic.DrawPointDictionary(points);

            textBoxInfo.Text = Calculator.printPoints(points);
        }

        private void btnKMeans_Click(object sender, EventArgs e)
        {
            //List<Point> seeds = new List<Point>{
            //    new Point(200, 200),
            //    new Point(400, 400),
            //    new Point(200, 400)
            //};

            SeedGenerator seedG = new SeedGenerator(); //
            seedG.SetPoints(points);
            seedG.seedCount = 3; // by default

            if (Int32.TryParse(textBoxSetSeedsCount.Text, out int seedCount))
                seedG.seedCount = seedCount;


            List<Point> seeds = seedG.GetSeeds(); // Calculate and get seeds


            k_means.SetPoints(points);
            k_means.SetSeeds(seeds);
            k_means.startK_means();

            textBoxInfo.Text = Calculator.printPoints(k_means.getPoints());
        }

        private void btnForel_Click(object sender, EventArgs e)
        {
            forel.setPoints(points);
            forel.Radius = 100;

            if (Int32.TryParse(textBoxSetRadius.Text, out int radius))
                forel.Radius = radius;

            forel.startForel();
            textBoxInfo.Text = Calculator.printPoints(forel.getPoints());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictBoxArea.Image = null;
            textBoxInfo.Clear();

            forel.clearFields();

            forel.drawRoute().Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Tuple<Point, Point, double> element in forel.drawRoute())
            {
                textBox3.Text += Convert.ToString(element + "\n");
            }
            graphic.RouteDrow(forel.drawRoute());
        }
    }
}
