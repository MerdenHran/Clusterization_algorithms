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
        EnergyCalculator energyCalculator;
        Dictionary<Point, int> allPoints;
        Dictionary<Point, int> allPointsClustered;
        List<Point> clusterCenters = new List<Point> { };
        int radius; // in forel
        ClusterizationType clusterizationType;

        // *** DEFAULT VALUES ***
        int def_points_count = 100; // count nodes generated on map
        int def_cluster_radius = 100; // round forel cluster radius
        int def_seed_count = 2; // count of centroids in k-means
        
        // FPPWR net draw default values
        int def_net_rows = 6;
        int def_net_cols = 6;

        // counters
        int loop_count = 0; // times was data collected from map by station
        double map_usedE = 0; // used energy in current loop
        double map_last_usedE = 0; // used energy in last loop

        public Form1()
        {
            InitializeComponent();
            //pictBoxArea.Size = new System.Drawing.Size(600, 600); //800 x 738
            graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);

            forel = new Forel(graphic);
            k_means = new K_means(graphic);
            routeBuilder = new RouteBuilder();
        }

        private void btnGenPoints_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("PictBoxArea: W(X)=" + pictBoxArea.Width + " H(Y)=" + pictBoxArea.Height);
            DisableAll();
            EnableClusterization();
            Labels_ClearText();
            buttonReloadMap.Enabled = true;
            buttonEnergyModel.Enabled = true;

            if (checkBoxAllowGeneratePoints.Checked == true)
            {
                if (Int32.TryParse(textBoxSetPointsCount.Text, out int pointsCount))
                    allPoints = Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);
                else
                    allPoints = Calculator.generatePoints(def_points_count, pictBoxArea.Width, pictBoxArea.Height);
            }

            allPointsClustered = allPoints;
            routeBuilder.RouteList = new List<Point> { };
            energyCalculator = new EnergyCalculator(graphic, allPoints);

            ClearFields();
        }

        public void ClearFields() {
            graphics.Clear(Color.White);
            textBoxInfo.Clear();
            graphic.DrawPointDictionary(allPoints);
            PrintToTextBoxInfo(allPoints);
            clusterCenters.Clear();
        }

        private void btnKMeans_Click(object sender, EventArgs e)
        {
            clusterizationType = ClusterizationType.K_means;
            Labels_ClearText();
            ClearFields();
            EnableRouteCalculating();
            DisallowSelectClusterAndCalculateEnergy();

            SeedGenerator seedG = new SeedGenerator(); //
            seedG.SetPoints(allPoints);
            seedG.seedCount = def_seed_count; // by default

            if (Int32.TryParse(textBoxSetSeedsCount.Text, out int seedCount))
                seedG.seedCount = seedCount;

            List<Point> seeds = seedG.GetSeeds(); // Calculate and get seeds

            k_means.setPoints(allPoints);
            k_means.Seeds = seeds;
            k_means.startK_means();

            clusterCenters = k_means.Seeds;

            PrintToTextBoxInfo(k_means.getPoints());
            allPointsClustered = k_means.getPoints();
        }

        private void btnForel_Click(object sender, EventArgs e)
        {
            clusterizationType = ClusterizationType.Forel;
            Labels_ClearText();
            ClearFields();
            EnableRouteCalculating();
            DisallowSelectClusterAndCalculateEnergy();

            forel.setPoints(allPoints);
            forel.Radius = def_cluster_radius;

            if (Int32.TryParse(textBoxSetRadius.Text, out int r))
                forel.Radius = r;

            radius = forel.Radius;
            forel.startForel();
            clusterCenters = forel.listOfClastersCenter;

            PrintToTextBoxInfo(forel.getPoints());
            allPointsClustered = forel.getPoints();
        }

        private void btnClustersRoute_Click(object sender, EventArgs e)
        {
            AllowSelectClusterAndCalculateEnergy();

            if (clusterCenters.Count == 0)
                routeBuilder.All_points(Calculator.DictionaryToList(allPoints));
            else
                routeBuilder.All_points(clusterCenters);

            routeBuilder.CalculateRouteByConvexHullInsertion();
            graphic.DrawRoute(routeBuilder.RouteList, Color.Yellow);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);

            //allPointsClustered = routeBuilder.SortClustersByRoute(allPointsClustered);
            PrintToTextBoxInfo(allPointsClustered);
        }

        private void btnSpiralRoute_Click(object sender, EventArgs e)
        {
            AllowSelectClusterAndCalculateEnergy();
            btnConvexHull.Enabled = false;

            if (clusterCenters.Count > 0)
                routeBuilder.All_points(clusterCenters);
            else
                routeBuilder.All_points(Calculator.DictionaryToList(allPoints));

            routeBuilder.JarvisMarch(true);
            graphic.DrawRoute(routeBuilder.Convex_hull, Color.Aqua);
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
            AllowSelectClusterAndCalculateEnergy();
            List<Point> route = new List<Point> { };

            if (clusterCenters.Count > 0)
                route = routeBuilder.CalculateRouteBruteForce(clusterCenters);
            else
                route = routeBuilder.CalculateRouteBruteForce(Calculator.DictionaryToList(allPoints));

            graphic.DrawRoute(route, Color.Blue);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route), 3);
            //allPointsClustered = routeBuilder.SortClustersByRoute(allPointsClustered);
            PrintToTextBoxInfo(allPointsClustered);
        }

        private void btn1ClusterOn_Click(object sender, EventArgs e)
        {
            DisableAll();
            btnDeselectCluster.Enabled = true;
            graphics.Clear(Color.White);
            int clusterNum = 1;

            if (Int32.TryParse(textBoxSetClusterNum.Text, out int num)) // get cluster number
                clusterNum = num;

            List<Point> cluster = Calculator.getClusterList(clusterNum, allPointsClustered);
            PrintToTextBoxInfo(Calculator.getClusterDictionary(clusterNum, allPointsClustered));

            Point center = Calculator.findCentroid(cluster);    // find cluster center
            List<Point> routeFragment = Calculator.getRouteFragment(center, routeBuilder.RouteList); // find part route go throught cluster

            //< Move all points to the start coordinate
            Point vector = new Point(center.X - radius, center.Y - radius);
            center = new Point(radius, radius);
            Calculator.MovePointList(cluster, vector);
            Calculator.MovePointList(routeFragment, vector);
            //>

            //< Calculate zoom coefficient. 
            int size = pictBoxArea.Height;
            if (pictBoxArea.Width < size)
                size = pictBoxArea.Width;

            double zoom = size / (radius * 2.0); // proportion between cluster zone size and field size
            //>

            //< Calculate new points position, radius with zooming
            int newRadius = (int)Math.Round(radius * zoom);
            Point newCenter = new Point((int)Math.Round(center.X * zoom), (int)Math.Round(center.Y * zoom));
            Calculator.ZoomPointList(cluster, zoom);
            Calculator.ZoomPointList(routeFragment, zoom);

            graphic.DrawPoint(newCenter, Brushes.Red);
            graphic.DrawCircle(newCenter, newRadius, Color.Black, 0);
            graphic.DrawPointList(cluster);
            graphic.DrawRoute(routeFragment, Color.Orange);
            //>
        }

        private void DrawAllSavedObjects() {
            graphics.Clear(Color.White);
            textBoxInfo.Clear();
            PrintToTextBoxInfo(allPointsClustered);

            if (allPoints.Count != 0)
                graphic.DrawPointDictionary(allPoints);

            if (clusterCenters.Count != 0) {
                for (int i = 0; i < clusterCenters.Count; i++) {
                    graphic.DrawPoint(clusterCenters[i], Brushes.Red, 6);
                    
                    if(clusterizationType == ClusterizationType.Forel)
                        graphic.DrawCircle(clusterCenters[i], radius, Color.Black, 0);
                }
            }

            if (routeBuilder.RouteList.Count != 0)
            {
                graphic.DrawRoute(routeBuilder.RouteList, Color.Orange, 0);
                labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);
            }
        }

        private void btnCalcEnergy_Click(object sender, EventArgs e) {
            DrawAllSavedObjects();
            buttonStatistic.Enabled = true;
            loop_count++;
            map_last_usedE = map_usedE;

            ConnectionType connectionType = ConnectionType.DT_to_Center; // default connection

            switch (comboBoxConnectionType.SelectedIndex) {
                case 1:
                    connectionType = ConnectionType.DT_to_Route;
                    break;

                case 2:
                    connectionType = ConnectionType.PP_to_Center;
                    break;
                
                case 3:
                    connectionType = ConnectionType.PP_to_Route;
                    break;
            }

            energyCalculator.CalculteAllNodesEnergy(connectionType, allPointsClustered, routeBuilder.RouteList, ReadStationHeighth());
            PrintToTextBoxInfo(allPointsClustered);

            labelCharge.Visible = true;
            labelUsedEnergy.Visible = true;
            map_usedE = energyCalculator.GetMapUsedEnergy();
            labelCharge.Text = "Total charge: " + String.Format("{0:0.000}", energyCalculator.GetMapCurrentChargeInPercents()) + "%";
            labelUsedEnergy.Text = "Used energy: " + String.Format("{0:0.000}", map_usedE) + " (J)";
            if (labelInfo.Enabled) ReloadStatistic();
        }

        private int ReadStationHeighth() {
            int station_height = 0;

            if (int.TryParse(textBoxSetHeight.Text, out int height))
                station_height = height;

            return station_height;
        }

        private void PrintToTextBoxInfo(Dictionary<Point, int> dictionary) {
            textBoxInfo.Text = Calculator.printNodesAndCharge(dictionary, energyCalculator.GetNodesChargeDictionary());
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawScale();
        }

        private void DrawScale() // draw scale in panel related to picturebox
        {
            int step = 25;

            // Set panel size to all window 
            panel.Size = new Size(this.Size.Width, this.Size.Height);
            panel.Location = new Point(0, 0);

            Graphics graphicsVector = panel.CreateGraphics();

            Pen pen = new Pen(Color.Black, 2);
            Point zeroPosition = new Point(pictBoxArea.Location.X - 25, pictBoxArea.Location.Y - 25);
            int X = zeroPosition.X;
            int Y = zeroPosition.Y;

            graphicsVector.DrawLine(pen, new Point(X, Y), new Point(pictBoxArea.Location.X + pictBoxArea.Width, Y));
            graphicsVector.DrawLine(pen, new Point(X, Y), new Point(X, pictBoxArea.Location.Y + pictBoxArea.Height));

            int distanceX = pictBoxArea.Width + 10;

            int number = 0;

            for (int i = step; i <= distanceX;)
            {
                graphicsVector.DrawLine(pen, new Point(X + i, Y - 3), new Point(X + i, Y + 3));


                if (i % (2 * step) != 0)
                {
                    if (number == 0)
                    {
                        Label lb = new Label
                        {
                            Location = new Point(X + i - 6, Y - 15),
                            Text = $"{number}",
                            AutoSize = true

                        };
                        panel.Controls.Add(lb);
                    }
                    else
                    {
                        Label lb = new Label
                        {
                            Location = new Point(X + i - 10, Y - 15),
                            Text = $"{number}",
                            AutoSize = true

                        };
                        panel.Controls.Add(lb);
                    }
                }

                i += 25;
                number += 25;
            }

            number = 0;

            int distanceY = pictBoxArea.Height + 25;


            for (int i = 25; i < distanceY;)
            {
                graphicsVector.DrawLine(pen, new Point(X - 3, Y + i), new Point(X + 3, Y + i));
                if (i % 50 != 0)
                {
                    if (number == 0)
                    {
                        Label lb = new Label
                        {
                            Location = new Point(X - 15, Y + i - 7),
                            Text = $"{number}",
                            AutoSize = true

                        };
                        panel.Controls.Add(lb);
                    }
                    else if (number == 50)
                    {
                        Label lb = new Label
                        {
                            Location = new Point(X - 23, Y + i - 7),
                            Text = $"{number}",
                            AutoSize = true

                        };
                        panel.Controls.Add(lb);
                    }
                    else
                    {
                        Label lb = new Label
                        {
                            Location = new Point(X - 27, Y + i - 7),
                            Text = $"{number}",
                            AutoSize = true

                        };
                        panel.Controls.Add(lb);
                    }

                }

                i += 25;
                number += 25;
            }
        }

        private void btnNearestNeighbour_Click(object sender, EventArgs e)
        {
            AllowSelectClusterAndCalculateEnergy();
            btnConvexHull.Enabled = true;
            List<Point> route = new List<Point> { };

            if (clusterCenters.Count > 0)
                route = routeBuilder.CalculateRouteByNearestNeighbour(clusterCenters);
            else
                route = routeBuilder.CalculateRouteByNearestNeighbour(Calculator.DictionaryToList(allPoints));

            graphic.DrawRoute(route, Color.Salmon);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route), 3);
            PrintToTextBoxInfo(allPointsClustered);
        }

        private void btnFPPWR_Click(object sender, EventArgs e)
        {
            AllowSelectClusterAndCalculateEnergy();
            btnConvexHull.Enabled = true;
            List<Point> route = new List<Point> { };

            //< draw net on pictBoxArea
            // divide field on cells; cells count:
            int x_count = def_net_cols;
            int y_count = def_net_rows;

            graphic.DrawNet(x_count, y_count, pictBoxArea.Width, pictBoxArea.Height);
            //>

            if (clusterCenters.Count > 0)
                route = routeBuilder.CalculateRouteByFPPWR(clusterCenters, x_count, y_count, pictBoxArea.Width, pictBoxArea.Height);
            else
                route = routeBuilder.CalculateRouteByFPPWR(Calculator.DictionaryToList(allPoints), x_count, y_count, pictBoxArea.Width, pictBoxArea.Height);

            graphic.DrawRoute(route, Color.Purple);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route), 3);
            PrintToTextBoxInfo(allPointsClustered);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            labelInfo.Text = 
                "black points - nodes\n" +
                "big red points - mass centers of clusters\n" +
                "red points - nodes with 0 % charge\n" +
                "black circles - clusters\n" +
                "gray circles - clusters iterations\n" +
                "green line - transmittion model for close distance (< 87, 7m)\n" +
                "red line - transmittion model for long distance (> 87, 7m) (with using amplifier)\n" +
                "route colors -different for each route-building algorithm, allow to see difference";

            CheckLabelInfo();
        }

        private void Labels_ClearText() {
            labelRoute.Text = "";
            labelCharge.Text = " ";
            labelUsedEnergy.Text = " ";
        }

        // ***** Protect from user errors *****
        private void EnableClusterization() { 
            btnKMeans.Enabled = true;
            btnForel.Enabled = true;
        }
        private void DisableClusterization()
        {
            btnKMeans.Enabled = false;
            btnForel.Enabled = false;
        }

        private void EnableRouteCalculating()
        {
            btnNearestNeighbour.Enabled = true;
            btnConvexHull.Enabled = true;
            btnBruteForce.Enabled = true;
            btnSpiralRoute.Enabled = true;
            btnFPPWR.Enabled = true;
        }

        private void DisableRouteCalculating()
        {
            btnNearestNeighbour.Enabled = false;
            btnConvexHull.Enabled = false;
            btnBruteForce.Enabled = false;
            btnSpiralRoute.Enabled = false;
            btnFPPWR.Enabled = false;
        }

        private void DisableAll() { 
            DisableClusterization();
            DisableRouteCalculating();
            btnSelectCluster.Enabled = false;
            btnCalcEnergy.Enabled = false;
            buttonStatistic.Enabled = false;
        }

        private void AllowSelectClusterAndCalculateEnergy() { 
            btnSelectCluster.Enabled = true;
            btnCalcEnergy.Enabled = true;
            buttonStatistic.Enabled = false;
        }

        private void DisallowSelectClusterAndCalculateEnergy()
        {
            btnSelectCluster.Enabled = false;
            btnCalcEnergy.Enabled = false;
            buttonStatistic.Enabled = false;
            loop_count = 0;
            map_usedE = 0;
            map_last_usedE = 0;
        }

        // *******************************

        private void btnDeselectCluster_Click(object sender, EventArgs e)
        {
            DrawAllSavedObjects();
            btnDeselectCluster.Enabled = false;
            btnSelectCluster.Enabled = true;
            btnCalcEnergy.Enabled = true;
            EnableClusterization();
            EnableRouteCalculating();
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            ReloadStatistic();
            CheckLabelInfo();
        }

        private void ReloadStatistic() {
            double map_capacity = energyCalculator.GetNodesCapacity(allPoints.Count);
            double map_charge = energyCalculator.GetMapCurrentCharge();
            double map_charge_percents = energyCalculator.GetMapCurrentChargeInPercents();
            int nodes_available = getCountOfAvailableNodes();

            labelInfo.Text =
                "Total nodes charge: " + map_charge_percents + "% (" + map_charge + " / " + map_capacity + " J)\n" +
                "Available nodes: " + nodes_available + " / " + allPointsClustered.Count + "\n" +
                "Clusters count: " + forel.clusterNum + "\n" +
                "Loops: " + loop_count + "\n" +
                "Average E, per loop: " + String.Format("{0:0.000}", (map_capacity - map_charge) / loop_count) + " J\n" +
                "Last loop used E: " + String.Format("{0:0.000}", map_usedE - map_last_usedE) + " J";
        }

        private void buttonReloadMap_Click(object sender, EventArgs e)
        {
            DrawAllSavedObjects();
        }

        private void CheckLabelInfo() {
            if (labelInfo.Visible)
                labelInfo.Visible = false;
            else
                labelInfo.Visible = true;
        }

        private int getCountOfAvailableNodes() {
            
            int count = 0;

            var nodes_charge = energyCalculator.GetNodesChargeDictionary();

            foreach (var node in nodes_charge)
                if (node.Value != 0) count++;

            return count;
        }

        private void buttonEnergyModel_Click(object sender, EventArgs e)
        {
            CheckLabelInfo();

            labelInfo.Text =
                "Field size: " + pictBoxArea.Width + " x " + pictBoxArea.Height + " m" +
                "\nAmplifier energy:" +
                "\n     Free space model " + "(<= " + energyCalculator.d0 + " m):  " + energyCalculator.E_fs + " nJ" +
                "\n     Multipath fading model " + "(> " + energyCalculator.d0 + " m):  " + energyCalculator.E_mp * 1000000 + " mJ" +
                "\nInitial node energy: " + energyCalculator.node_E / 1000000000.000 + " J" +
                "\nEnergy for signal transmittion / recieve: " + energyCalculator.E_elec + " nJ/bit" +
                "\nPackage size (20 - 65535): " + energyCalculator.package + " bit" +
                "\nThreshold for swapping amplification models: " + energyCalculator.d0 + " m";
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.facebook.com");
        }
    }
}