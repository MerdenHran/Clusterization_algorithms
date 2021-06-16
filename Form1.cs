using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clusterization_algorithms
{
    public partial class Form1 : Form
    {
        Graphic graphic;
        Forel forel;
        K_means k_means;
        Route route;
        Dictionary<Point, int> allPoints;
        List<Point> clustersCenter = new List<Point> { };
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);

            forel = new Forel(graphic);
            k_means = new K_means(graphic);
            route = new Route();
        }

        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);

            if(!Int32.TryParse(textBoxSetPointsCount.Text, out int pointsCount))
                pointsCount = 200;

            allPoints = Calculator.setStaticPoints();
            //points = Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);

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

            route.All_points(Calculator.DictionaryToList(allPoints));
            route.CalculateRoute();
            graphic.DrawRoute(route.RouteList);
            labelRoute.Text = "Route length: " +  Math.Round(Calculator.calcRouteLength(route.RouteList), 3);
        }

        private void btnClustersRoute_Click(object sender, EventArgs e)
        {
            route.All_points(clustersCenter);
            route.CalculateRoute();
            graphic.DrawRoute(route.RouteList);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route.RouteList), 3);
        }

        private void btnSpiralRoute_Click(object sender, EventArgs e)
        {
            labelRoute.Text = "";
            ClearFields();

            route.All_points(Calculator.DictionaryToList(allPoints));
            route.JarvisMarch(true);
            graphic.DrawRoute(route.Convex_hull);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route.Convex_hull), 3);
        }
    }
}
