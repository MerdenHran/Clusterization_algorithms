﻿using System;
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
        // List<Point> route = new List<Point> { };

        // *** DEFAULT VALUES ***
        int def_points_count = 100; // count nodes generated on map
        int def_cluster_radius = 100; // round forel cluster radius
        int def_seed_count = 2; // count of centroids in k-means
        
        // FPPWR net draw default values
        int def_net_rows = 6;
        int def_net_cols = 6;

        // **********************

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

            labelRoute.Text = "";
            labelCharge.Text = " ";
            labelUsedEnergy.Text = " ";

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
            labelRoute.Text = "";
            ClearFields();

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
            labelRoute.Text = "";
            ClearFields();

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
            if (clusterCenters.Count == 0)
                routeBuilder.All_points(Calculator.DictionaryToList(allPoints));
            else
                routeBuilder.All_points(clusterCenters);

            routeBuilder.CalculateRouteByConvexHullInsertion();
            graphic.DrawRoute(routeBuilder.RouteList, Color.Orange);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(routeBuilder.RouteList), 3);

            //allPointsClustered = routeBuilder.SortClustersByRoute(allPointsClustered);
            PrintToTextBoxInfo(allPointsClustered);
        }

        private void btnSpiralRoute_Click(object sender, EventArgs e)
        {
            //labelRoute.Text = "";
            //ClearFields();

            if (clusterCenters.Count > 0)
                routeBuilder.All_points(clusterCenters);
            else
                routeBuilder.All_points(Calculator.DictionaryToList(allPoints));

            routeBuilder.JarvisMarch(true);
            graphic.DrawRoute(routeBuilder.Convex_hull, Color.DarkMagenta);
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

        private void btn1ClusterOff_Click(object sender, EventArgs e)
        {
            DrawAllSavedObjects();
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

            //Console.WriteLine(connectionType.ToString());
            //Calculator.Console_PrintDictionary(allPointsClustered);
            //Calculator.Console_PrintPointList(routeBuilder.RouteList);

            energyCalculator.CalculteAllNodesEnergy(connectionType, allPointsClustered, routeBuilder.RouteList, ReadStationHeighth());
            PrintToTextBoxInfo(allPointsClustered);

            labelCharge.Visible = true;
            labelUsedEnergy.Visible = true;
            labelCharge.Text = "Total charge: " + energyCalculator.GetMapCurrentChargeInPercents().ToString() + "%";
            labelUsedEnergy.Text = "Used energy: " + energyCalculator.GetMapUsedEnergy().ToString() + " (J)";
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

            graphic.DrawRoute(route, Color.Crimson);
            labelRoute.Text = "Route length: " + Math.Round(Calculator.calcRouteLength(route), 3);
            PrintToTextBoxInfo(allPointsClustered);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (labelHelpMap.Visible)
                labelHelpMap.Visible = false;
            else
                labelHelpMap.Visible = true;
        }
    }
}