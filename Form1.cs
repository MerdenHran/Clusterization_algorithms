using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clusterization_algorithms
{
    public partial class Form1 : Form
    {
        Graphic graphic;
        Graphics graphics;
        Forel forel;
        K_means k_means;
        RouteBuilder routeBuilder;
        Dictionary<Point, int> allPoints;
        List<Point> clustersCenter = new List<Point> { };

        public Form1()
        {
            InitializeComponent();
            graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);

            forel = new Forel(graphic);
            k_means = new K_means(graphic);
            routeBuilder = new RouteBuilder();
            //pictBox1Cluster.Visible = false;
        }

        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);

            allPoints = Calculator.setStaticPoints();

            if (Int32.TryParse(textBoxSetPointsCount.Text, out int pointsCount))
                allPoints = Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);

            ClearFields();
        }

        public void ClearFields() {
            graphics.Clear(Color.White);
            textBoxInfo.Clear();
            graphic.DrawPointDictionary(allPoints);
            textBoxInfo.Text = Calculator.printPointsDictionary(allPoints);
            clustersCenter.Clear();
        }

        private void btnKMeans_Click(object sender, EventArgs e)
        {
            labelRoute.Text = "";
            ClearFields();

            SeedGenerator seedG = new SeedGenerator(); //
            seedG.SetPoints(allPoints);
            seedG.seedCount = 3; // by default

            if (Int32.TryParse(textBoxSetSeedsCount.Text, out int seedCount))
                seedG.seedCount = seedCount;

            List<Point> seeds = seedG.GetSeeds(); // Calculate and get seeds

            k_means.setPoints(allPoints);
            k_means.Seeds = seeds;
            k_means.startK_means();

            clustersCenter = k_means.Seeds;

            textBoxInfo.Text = Calculator.printPointsDictionary(k_means.getPoints());
        }

        private void btnForel_Click(object sender, EventArgs e)
        {
            labelRoute.Text = "";
            ClearFields();

            forel.setPoints(allPoints);
            forel.Radius = 100;

            if (Int32.TryParse(textBoxSetRadius.Text, out int radius))
                forel.Radius = radius;

            forel.startForel();
            clustersCenter = forel.listOfClastersCenter;

            textBoxInfo.Text = Calculator.printPointsDictionary(forel.getPoints());
        }

        private void btnRoute_Click(object sender, EventArgs e) // all points route
        {
            labelRoute.Text = "";
            ClearFields();

            routeBuilder.All_points(Calculator.DictionaryToList(allPoints));
            routeBuilder.CalculateRoute();
            graphic.DrawRoute(routeBuilder.RouteList, Color.Orange);
            labelRoute.Text = "Route length: " +  Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);
        }

        private void btnClustersRoute_Click(object sender, EventArgs e)
        {
            routeBuilder.All_points(clustersCenter);
            routeBuilder.CalculateRoute();
            graphic.DrawRoute(routeBuilder.RouteList, Color.Orange);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);
        }

        private void btnSpiralRoute_Click(object sender, EventArgs e)
        {
            labelRoute.Text = "";
            ClearFields();

            routeBuilder.All_points(Calculator.DictionaryToList(allPoints));
            routeBuilder.JarvisMarch(true);
            graphic.DrawRoute(routeBuilder.Convex_hull, Color.Orange);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.Convex_hull), 3);
        }

        private void btnGenPoints_MouseMove(object sender, MouseEventArgs e)
        {
            btnGenPoints.BackColor = Color.LightGreen;
        }

        private void btnGenPoints_MouseLeave(object sender, EventArgs e)
        {
            btnGenPoints.BackColor = Color.DarkGray;
        }

        private void btnBruteForce_Click(object sender, EventArgs e)
        {
            List<Point> route = routeBuilder.CalculateRouteBruteForce(clustersCenter);
            graphic.DrawRoute(route, Color.Blue);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route), 3);
        }

        private void btn1ClusterOn_Click(object sender, EventArgs e)
        {
            pictBox1Cluster.Visible = true;
            Console.WriteLine("PictBox1Cluster: W(X)=" + pictBox1Cluster.Width + " H(Y)=" + pictBox1Cluster.Height);

        }

        private void btn1ClusterOff_Click(object sender, EventArgs e)
        {
            pictBox1Cluster.Visible = false;
        }
    }
}
