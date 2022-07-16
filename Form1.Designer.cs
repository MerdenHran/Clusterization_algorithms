
namespace Clusterization_algorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxSetPointsCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSetRadius = new System.Windows.Forms.TextBox();
            this.btnForel = new System.Windows.Forms.Button();
            this.btnGenPoints = new System.Windows.Forms.Button();
            this.btnKMeans = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSetSeedsCount = new System.Windows.Forms.TextBox();
            this.btnSpiralRoute = new System.Windows.Forms.Button();
            this.btnConvexHull = new System.Windows.Forms.Button();
            this.btnBruteForce = new System.Windows.Forms.Button();
            this.btnSelectCluster = new System.Windows.Forms.Button();
            this.textBoxSetClusterNum = new System.Windows.Forms.TextBox();
            this.btnDeselectCluster = new System.Windows.Forms.Button();
            this.btnCalcEnergy = new System.Windows.Forms.Button();
            this.textBoxSetHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.checkBoxAllowGeneratePoints = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonEnergyModel = new System.Windows.Forms.Button();
            this.buttonReloadMap = new System.Windows.Forms.Button();
            this.labelUsedEnergy = new System.Windows.Forms.Label();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.labelRoute = new System.Windows.Forms.Label();
            this.pictBoxArea = new System.Windows.Forms.PictureBox();
            this.btnNearestNeighbour = new System.Windows.Forms.Button();
            this.btnFPPWR = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelTextBoxInfoTip = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.AcceptsReturn = true;
            this.textBoxInfo.AcceptsTab = true;
            this.textBoxInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(887, 38);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(268, 758);
            this.textBoxInfo.TabIndex = 9;
            // 
            // textBoxSetPointsCount
            // 
            this.textBoxSetPointsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetPointsCount.Location = new System.Drawing.Point(1336, 118);
            this.textBoxSetPointsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetPointsCount.Name = "textBoxSetPointsCount";
            this.textBoxSetPointsCount.Size = new System.Drawing.Size(145, 32);
            this.textBoxSetPointsCount.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxSetPointsCount, "default: 100");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1162, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set nodes count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1164, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set cluster radius:";
            this.toolTip1.SetToolTip(this.label1, "Forel have round clusters.\r\nSet cluster radius to start");
            // 
            // textBoxSetRadius
            // 
            this.textBoxSetRadius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetRadius.Location = new System.Drawing.Point(1168, 267);
            this.textBoxSetRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetRadius.Name = "textBoxSetRadius";
            this.textBoxSetRadius.Size = new System.Drawing.Size(137, 32);
            this.textBoxSetRadius.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textBoxSetRadius, "default: 100");
            // 
            // btnForel
            // 
            this.btnForel.BackColor = System.Drawing.Color.DarkGray;
            this.btnForel.Enabled = false;
            this.btnForel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForel.Location = new System.Drawing.Point(1330, 260);
            this.btnForel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForel.Name = "btnForel";
            this.btnForel.Size = new System.Drawing.Size(154, 45);
            this.btnForel.TabIndex = 11;
            this.btnForel.Text = "Forel";
            this.toolTip1.SetToolTip(this.btnForel, "Click to start.\r\nDon\'t forget to generate points at first!");
            this.btnForel.UseVisualStyleBackColor = false;
            this.btnForel.Click += new System.EventHandler(this.btnForel_Click);
            // 
            // btnGenPoints
            // 
            this.btnGenPoints.BackColor = System.Drawing.Color.DarkGray;
            this.btnGenPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenPoints.Location = new System.Drawing.Point(1170, 28);
            this.btnGenPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenPoints.Name = "btnGenPoints";
            this.btnGenPoints.Size = new System.Drawing.Size(317, 52);
            this.btnGenPoints.TabIndex = 10;
            this.btnGenPoints.Text = "Draw nodes map";
            this.btnGenPoints.UseVisualStyleBackColor = false;
            this.btnGenPoints.Click += new System.EventHandler(this.btnGenPoints_Click);
            this.btnGenPoints.MouseLeave += new System.EventHandler(this.btnGenPoints_MouseLeave);
            this.btnGenPoints.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGenPoints_MouseMove);
            // 
            // btnKMeans
            // 
            this.btnKMeans.BackColor = System.Drawing.Color.DarkGray;
            this.btnKMeans.Enabled = false;
            this.btnKMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKMeans.Location = new System.Drawing.Point(1332, 194);
            this.btnKMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKMeans.Name = "btnKMeans";
            this.btnKMeans.Size = new System.Drawing.Size(154, 45);
            this.btnKMeans.TabIndex = 17;
            this.btnKMeans.Text = "k-means++";
            this.toolTip1.SetToolTip(this.btnKMeans, "Click to start.\r\nDon\'t forget to generate points at first!");
            this.btnKMeans.UseVisualStyleBackColor = false;
            this.btnKMeans.Click += new System.EventHandler(this.btnKMeans_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1168, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Set seeds count";
            this.toolTip1.SetToolTip(this.label3, "Seeds - it\'s clusters centroids.\r\nSet value to start");
            // 
            // textBoxSetSeedsCount
            // 
            this.textBoxSetSeedsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetSeedsCount.Location = new System.Drawing.Point(1171, 201);
            this.textBoxSetSeedsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetSeedsCount.Name = "textBoxSetSeedsCount";
            this.textBoxSetSeedsCount.Size = new System.Drawing.Size(137, 32);
            this.textBoxSetSeedsCount.TabIndex = 24;
            this.toolTip1.SetToolTip(this.textBoxSetSeedsCount, "default: 2");
            // 
            // btnSpiralRoute
            // 
            this.btnSpiralRoute.BackColor = System.Drawing.Color.Aqua;
            this.btnSpiralRoute.Enabled = false;
            this.btnSpiralRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpiralRoute.Location = new System.Drawing.Point(1168, 461);
            this.btnSpiralRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpiralRoute.Name = "btnSpiralRoute";
            this.btnSpiralRoute.Size = new System.Drawing.Size(319, 45);
            this.btnSpiralRoute.TabIndex = 29;
            this.btnSpiralRoute.Text = "Spiral route";
            this.toolTip1.SetToolTip(this.btnSpiralRoute, "Build a spiral route on points.\r\nLike convex hull but without final point");
            this.btnSpiralRoute.UseVisualStyleBackColor = false;
            this.btnSpiralRoute.Click += new System.EventHandler(this.btnSpiralRoute_Click);
            // 
            // btnConvexHull
            // 
            this.btnConvexHull.BackColor = System.Drawing.Color.Yellow;
            this.btnConvexHull.Enabled = false;
            this.btnConvexHull.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvexHull.Location = new System.Drawing.Point(1168, 363);
            this.btnConvexHull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvexHull.Name = "btnConvexHull";
            this.btnConvexHull.Size = new System.Drawing.Size(319, 45);
            this.btnConvexHull.TabIndex = 30;
            this.btnConvexHull.Text = "Convex hull insertion (modified)";
            this.toolTip1.SetToolTip(this.btnConvexHull, "Build route like a rope\r\n1. creates an outer contour\r\n2. narrows the contour ever" +
        "y time");
            this.btnConvexHull.UseVisualStyleBackColor = false;
            this.btnConvexHull.Click += new System.EventHandler(this.btnClustersRoute_Click);
            // 
            // btnBruteForce
            // 
            this.btnBruteForce.BackColor = System.Drawing.Color.Blue;
            this.btnBruteForce.Enabled = false;
            this.btnBruteForce.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBruteForce.Location = new System.Drawing.Point(1168, 314);
            this.btnBruteForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBruteForce.Name = "btnBruteForce";
            this.btnBruteForce.Size = new System.Drawing.Size(319, 45);
            this.btnBruteForce.TabIndex = 31;
            this.btnBruteForce.Text = "Route by Brute-force";
            this.toolTip1.SetToolTip(this.btnBruteForce, "Calculate all routes and find least\r\nNP-complete algorithm!\r\nCan be long calculat" +
        "ing time!\r\nRecommended route points count <10");
            this.btnBruteForce.UseVisualStyleBackColor = false;
            this.btnBruteForce.Click += new System.EventHandler(this.btnBruteForce_Click);
            // 
            // btnSelectCluster
            // 
            this.btnSelectCluster.BackColor = System.Drawing.Color.DarkGray;
            this.btnSelectCluster.Enabled = false;
            this.btnSelectCluster.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectCluster.Location = new System.Drawing.Point(1169, 574);
            this.btnSelectCluster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCluster.Name = "btnSelectCluster";
            this.btnSelectCluster.Size = new System.Drawing.Size(156, 45);
            this.btnSelectCluster.TabIndex = 32;
            this.btnSelectCluster.Text = "Select cluster";
            this.toolTip1.SetToolTip(this.btnSelectCluster, "Zoom and draw selected cluster");
            this.btnSelectCluster.UseVisualStyleBackColor = false;
            this.btnSelectCluster.Click += new System.EventHandler(this.btn1ClusterOn_Click);
            // 
            // textBoxSetClusterNum
            // 
            this.textBoxSetClusterNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetClusterNum.Location = new System.Drawing.Point(1377, 581);
            this.textBoxSetClusterNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetClusterNum.Name = "textBoxSetClusterNum";
            this.textBoxSetClusterNum.Size = new System.Drawing.Size(110, 32);
            this.textBoxSetClusterNum.TabIndex = 33;
            this.toolTip1.SetToolTip(this.textBoxSetClusterNum, "Write cluster number");
            // 
            // btnDeselectCluster
            // 
            this.btnDeselectCluster.BackColor = System.Drawing.Color.Salmon;
            this.btnDeselectCluster.Enabled = false;
            this.btnDeselectCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeselectCluster.Location = new System.Drawing.Point(1331, 574);
            this.btnDeselectCluster.Name = "btnDeselectCluster";
            this.btnDeselectCluster.Size = new System.Drawing.Size(40, 45);
            this.btnDeselectCluster.TabIndex = 35;
            this.btnDeselectCluster.Text = "×";
            this.toolTip1.SetToolTip(this.btnDeselectCluster, "Deselect cluster, draw map");
            this.btnDeselectCluster.UseVisualStyleBackColor = false;
            this.btnDeselectCluster.Click += new System.EventHandler(this.btnDeselectCluster_Click);
            // 
            // btnCalcEnergy
            // 
            this.btnCalcEnergy.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalcEnergy.Enabled = false;
            this.btnCalcEnergy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalcEnergy.Location = new System.Drawing.Point(1170, 623);
            this.btnCalcEnergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcEnergy.Name = "btnCalcEnergy";
            this.btnCalcEnergy.Size = new System.Drawing.Size(184, 45);
            this.btnCalcEnergy.TabIndex = 36;
            this.btnCalcEnergy.Text = "Calculate energy";
            this.toolTip1.SetToolTip(this.btnCalcEnergy, resources.GetString("btnCalcEnergy.ToolTip"));
            this.btnCalcEnergy.UseVisualStyleBackColor = false;
            this.btnCalcEnergy.Click += new System.EventHandler(this.btnCalcEnergy_Click);
            // 
            // textBoxSetHeight
            // 
            this.textBoxSetHeight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetHeight.Location = new System.Drawing.Point(1384, 677);
            this.textBoxSetHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetHeight.Name = "textBoxSetHeight";
            this.textBoxSetHeight.Size = new System.Drawing.Size(103, 32);
            this.textBoxSetHeight.TabIndex = 37;
            this.toolTip1.SetToolTip(this.textBoxSetHeight, "Set high");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1159, 680);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Set station flying height:";
            this.toolTip1.SetToolTip(this.label4, "Height where will move station.\r\nMore high - more distance to station\r\n(we can\'t " +
        "see it on 2D proection)");
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Items.AddRange(new object[] {
            "DT center",
            "DT route",
            "PP center",
            "PP route"});
            this.comboBoxConnectionType.Location = new System.Drawing.Point(1360, 630);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(127, 32);
            this.comboBoxConnectionType.TabIndex = 39;
            this.toolTip1.SetToolTip(this.comboBoxConnectionType, "Select connection type");
            // 
            // checkBoxAllowGeneratePoints
            // 
            this.checkBoxAllowGeneratePoints.AutoSize = true;
            this.checkBoxAllowGeneratePoints.Checked = true;
            this.checkBoxAllowGeneratePoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllowGeneratePoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAllowGeneratePoints.Location = new System.Drawing.Point(1167, 85);
            this.checkBoxAllowGeneratePoints.Name = "checkBoxAllowGeneratePoints";
            this.checkBoxAllowGeneratePoints.Size = new System.Drawing.Size(274, 28);
            this.checkBoxAllowGeneratePoints.TabIndex = 40;
            this.checkBoxAllowGeneratePoints.Text = "Allow to generate a new map";
            this.checkBoxAllowGeneratePoints.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonEnergyModel);
            this.panel.Controls.Add(this.buttonReloadMap);
            this.panel.Controls.Add(this.labelUsedEnergy);
            this.panel.Controls.Add(this.buttonStatistic);
            this.panel.Controls.Add(this.btnLink);
            this.panel.Controls.Add(this.labelCharge);
            this.panel.Controls.Add(this.labelInfo);
            this.panel.Controls.Add(this.btnHelp);
            this.panel.Controls.Add(this.labelRoute);
            this.panel.Controls.Add(this.pictBoxArea);
            this.panel.Location = new System.Drawing.Point(0, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(888, 816);
            this.panel.TabIndex = 41;
            // 
            // buttonEnergyModel
            // 
            this.buttonEnergyModel.BackColor = System.Drawing.Color.Magenta;
            this.buttonEnergyModel.Enabled = false;
            this.buttonEnergyModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnergyModel.Location = new System.Drawing.Point(829, 145);
            this.buttonEnergyModel.Name = "buttonEnergyModel";
            this.buttonEnergyModel.Size = new System.Drawing.Size(42, 37);
            this.buttonEnergyModel.TabIndex = 34;
            this.buttonEnergyModel.Text = "M";
            this.toolTip1.SetToolTip(this.buttonEnergyModel, "(Model) Energy model parameters");
            this.buttonEnergyModel.UseVisualStyleBackColor = false;
            this.buttonEnergyModel.Click += new System.EventHandler(this.buttonEnergyModel_Click);
            // 
            // buttonReloadMap
            // 
            this.buttonReloadMap.BackColor = System.Drawing.Color.Gold;
            this.buttonReloadMap.Enabled = false;
            this.buttonReloadMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReloadMap.Location = new System.Drawing.Point(830, 231);
            this.buttonReloadMap.Name = "buttonReloadMap";
            this.buttonReloadMap.Size = new System.Drawing.Size(42, 37);
            this.buttonReloadMap.TabIndex = 33;
            this.buttonReloadMap.Text = "R";
            this.toolTip1.SetToolTip(this.buttonReloadMap, "Reload Map");
            this.buttonReloadMap.UseVisualStyleBackColor = false;
            this.buttonReloadMap.Click += new System.EventHandler(this.buttonReloadMap_Click);
            // 
            // labelUsedEnergy
            // 
            this.labelUsedEnergy.AutoSize = true;
            this.labelUsedEnergy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsedEnergy.Location = new System.Drawing.Point(544, 760);
            this.labelUsedEnergy.Name = "labelUsedEnergy";
            this.labelUsedEnergy.Size = new System.Drawing.Size(120, 24);
            this.labelUsedEnergy.TabIndex = 32;
            this.labelUsedEnergy.Text = "___________";
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.BackColor = System.Drawing.Color.Red;
            this.buttonStatistic.Enabled = false;
            this.buttonStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistic.Location = new System.Drawing.Point(829, 188);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(42, 37);
            this.buttonStatistic.TabIndex = 31;
            this.buttonStatistic.Text = "S";
            this.toolTip1.SetToolTip(this.buttonStatistic, "Statistic");
            this.buttonStatistic.UseVisualStyleBackColor = false;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLink.Location = new System.Drawing.Point(829, 102);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(42, 37);
            this.btnLink.TabIndex = 30;
            this.btnLink.Text = "L";
            this.toolTip1.SetToolTip(this.btnLink, "Link to project site");
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharge.Location = new System.Drawing.Point(325, 760);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(120, 24);
            this.labelCharge.TabIndex = 29;
            this.labelCharge.Text = "___________";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(80, 65);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 25);
            this.labelInfo.TabIndex = 28;
            this.labelInfo.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Lime;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp.Location = new System.Drawing.Point(829, 59);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(42, 37);
            this.btnHelp.TabIndex = 27;
            this.btnHelp.Text = "?";
            this.toolTip1.SetToolTip(this.btnHelp, "Help");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoute.Location = new System.Drawing.Point(92, 760);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(120, 24);
            this.labelRoute.TabIndex = 26;
            this.labelRoute.Text = "___________";
            // 
            // pictBoxArea
            // 
            this.pictBoxArea.BackColor = System.Drawing.Color.White;
            this.pictBoxArea.Enabled = false;
            this.pictBoxArea.Location = new System.Drawing.Point(72, 59);
            this.pictBoxArea.Margin = new System.Windows.Forms.Padding(0);
            this.pictBoxArea.Name = "pictBoxArea";
            this.pictBoxArea.Size = new System.Drawing.Size(800, 738);
            this.pictBoxArea.TabIndex = 1;
            this.pictBoxArea.TabStop = false;
            // 
            // btnNearestNeighbour
            // 
            this.btnNearestNeighbour.BackColor = System.Drawing.Color.Salmon;
            this.btnNearestNeighbour.Enabled = false;
            this.btnNearestNeighbour.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNearestNeighbour.Location = new System.Drawing.Point(1169, 412);
            this.btnNearestNeighbour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNearestNeighbour.Name = "btnNearestNeighbour";
            this.btnNearestNeighbour.Size = new System.Drawing.Size(319, 45);
            this.btnNearestNeighbour.TabIndex = 42;
            this.btnNearestNeighbour.Text = "Route by nearest neighbour";
            this.toolTip1.SetToolTip(this.btnNearestNeighbour, "Build route to closest point every step");
            this.btnNearestNeighbour.UseVisualStyleBackColor = false;
            this.btnNearestNeighbour.Click += new System.EventHandler(this.btnNearestNeighbour_Click);
            // 
            // btnFPPWR
            // 
            this.btnFPPWR.BackColor = System.Drawing.Color.Purple;
            this.btnFPPWR.Enabled = false;
            this.btnFPPWR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFPPWR.Location = new System.Drawing.Point(1168, 510);
            this.btnFPPWR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFPPWR.Name = "btnFPPWR";
            this.btnFPPWR.Size = new System.Drawing.Size(319, 45);
            this.btnFPPWR.TabIndex = 43;
            this.btnFPPWR.Text = "Route by FPPWR";
            this.toolTip1.SetToolTip(this.btnFPPWR, resources.GetString("btnFPPWR.ToolTip"));
            this.btnFPPWR.UseVisualStyleBackColor = false;
            this.btnFPPWR.Click += new System.EventHandler(this.btnFPPWR_Click);
            // 
            // labelTextBoxInfoTip
            // 
            this.labelTextBoxInfoTip.AutoSize = true;
            this.labelTextBoxInfoTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextBoxInfoTip.Location = new System.Drawing.Point(894, 9);
            this.labelTextBoxInfoTip.Name = "labelTextBoxInfoTip";
            this.labelTextBoxInfoTip.Size = new System.Drawing.Size(223, 25);
            this.labelTextBoxInfoTip.TabIndex = 44;
            this.labelTextBoxInfoTip.Text = "[position, cluster] charge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 817);
            this.Controls.Add(this.labelTextBoxInfoTip);
            this.Controls.Add(this.btnFPPWR);
            this.Controls.Add(this.btnNearestNeighbour);
            this.Controls.Add(this.checkBoxAllowGeneratePoints);
            this.Controls.Add(this.comboBoxConnectionType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSetHeight);
            this.Controls.Add(this.btnCalcEnergy);
            this.Controls.Add(this.btnDeselectCluster);
            this.Controls.Add(this.textBoxSetClusterNum);
            this.Controls.Add(this.btnSelectCluster);
            this.Controls.Add(this.btnBruteForce);
            this.Controls.Add(this.btnConvexHull);
            this.Controls.Add(this.btnSpiralRoute);
            this.Controls.Add(this.textBoxSetSeedsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKMeans);
            this.Controls.Add(this.textBoxSetPointsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetRadius);
            this.Controls.Add(this.btnForel);
            this.Controls.Add(this.btnGenPoints);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Clusterization algorithms";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSetPointsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSetRadius;
        private System.Windows.Forms.Button btnForel;
        private System.Windows.Forms.Button btnGenPoints;
        private System.Windows.Forms.Button btnKMeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSetSeedsCount;
        private System.Windows.Forms.Button btnSpiralRoute;
        private System.Windows.Forms.Button btnConvexHull;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.Button btnSelectCluster;
        private System.Windows.Forms.TextBox textBoxSetClusterNum;
        private System.Windows.Forms.Button btnDeselectCluster;
        private System.Windows.Forms.Button btnCalcEnergy;
        private System.Windows.Forms.TextBox textBoxSetHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.CheckBox checkBoxAllowGeneratePoints;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnNearestNeighbour;
        private System.Windows.Forms.PictureBox pictBoxArea;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Button btnFPPWR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelTextBoxInfoTip;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Label labelUsedEnergy;
        private System.Windows.Forms.Button buttonReloadMap;
        private System.Windows.Forms.Button buttonEnergyModel;
        private System.Windows.Forms.Button btnLink;
    }
}

