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
        Dictionary<Point, int> allPointsClustered;
        List<Point> clusterCenters = new List<Point> { };
        int radius; // in forel
       // List<Point> route = new List<Point> { };

        public Form1()
        {
            InitializeComponent();
            graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);

            forel = new Forel(graphic);
            k_means = new K_means(graphic);
            routeBuilder = new RouteBuilder();
        }

        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);

            allPoints = Calculator.setStaticPoints();

            if (Int32.TryParse(textBoxSetPointsCount.Text, out int pointsCount))
                allPoints = Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);

            allPointsClustered = allPoints;

            ClearFields();
        }

        public void ClearFields() {
            graphics.Clear(Color.White);
            textBoxInfo.Clear();
            graphic.DrawPointDictionary(allPoints);
            textBoxInfo.Text = Calculator.printPointsDictionary(allPoints);
            clusterCenters.Clear();
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

            clusterCenters = k_means.Seeds;

            textBoxInfo.Text = Calculator.printPointsDictionary(k_means.getPoints());
            allPointsClustered = k_means.getPoints();
        }

        private void btnForel_Click(object sender, EventArgs e)
        {
            labelRoute.Text = "";
            ClearFields();

            forel.setPoints(allPoints);
            forel.Radius = 100;

            if (Int32.TryParse(textBoxSetRadius.Text, out int r))
                forel.Radius = r;

            radius = forel.Radius;
            forel.startForel();
            clusterCenters = forel.listOfClastersCenter;

            textBoxInfo.Text = Calculator.printPointsDictionary(forel.getPoints());
            allPointsClustered = forel.getPoints();
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
            routeBuilder.All_points(clusterCenters);
            routeBuilder.CalculateRoute();
            graphic.DrawRoute(routeBuilder.RouteList, Color.Orange);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);

            allPointsClustered = routeBuilder.SortClustersByRoute(allPointsClustered);
            textBoxInfo.Text = Calculator.printPointsDictionary(allPointsClustered);
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
            routeBuilder.All_points(clusterCenters);
            List<Point> route = routeBuilder.CalculateRouteBruteForce(clusterCenters);
            graphic.DrawRoute(route, Color.Blue);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route), 3);
            allPointsClustered = routeBuilder.SortClustersByRoute(allPointsClustered);
            textBoxInfo.Text = Calculator.printPointsDictionary(allPointsClustered);
        }

        private void btn1ClusterOn_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            int clusterNum = 1;

            if (Int32.TryParse(textBoxSetClusterNum.Text, out int num))
                clusterNum = num;

            List<Point> cluster = Calculator.getCluster(clusterNum, allPointsClustered);

            Point center = Calculator.findCentroid(cluster);
            //Point center = clusterCenters[clusterNum - 1];
            //Point center = routeBuilder.RouteList[clusterNum];
            
            //textBoxInfo.Text = Calculator.printPointList(cluster);
            //graphic.DrawPointList(cluster);
            //graphic.DrawPoint(center, Brushes.Red);
            //graphic.DrawCircle(center, radius, Color.Black, 0);

            Point vector = new Point(center.X - radius, center.Y - radius);
            center = new Point(radius, radius);
            Calculator.MoveCluster(cluster, vector);

            int size = pictBoxArea.Height;
            if (pictBoxArea.Width < size)
                size = pictBoxArea.Width;

            int zoom = size / radius;
            Console.WriteLine("zoom: " + zoom);
            //int xy = radius * zoom;
            //center = new Point(xy, xy);
            //Calculator.ZoomCluster(cluster, zoom);

            graphic.DrawPoint(center, Brushes.Red);
            graphic.DrawCircle(center, radius, Color.Black, 0);
            graphic.DrawPointList(cluster);

            //Calculator.printPointList(cluster);
        }

        private void btn1ClusterOff_Click(object sender, EventArgs e)
        {
            DrawAllObject();
        }

        private void DrawAllObject() {
            graphics.Clear(Color.White);
            textBoxInfo.Clear();
            textBoxInfo.Text = Calculator.printPointsDictionary(allPointsClustered);

            if (allPoints.Count != 0)
                graphic.DrawPointDictionary(allPoints);

            if (clusterCenters.Count != 0) {
                for (int i = 0; i < clusterCenters.Count; i++) {
                    graphic.DrawPoint(clusterCenters[i], Brushes.Red);
                    graphic.DrawCircle(clusterCenters[i], radius, Color.Black, 0);
                }
            }

            if (routeBuilder.RouteList.Count != 0)
            {
                graphic.DrawRoute(routeBuilder.RouteList, Color.Orange, 0);
                labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);
            }
        }
    }
}
