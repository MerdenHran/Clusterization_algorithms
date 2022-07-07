
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
            this.btnElasticNet = new System.Windows.Forms.Button();
            this.btnBruteForce = new System.Windows.Forms.Button();
            this.btn1ClusterOn = new System.Windows.Forms.Button();
            this.textBoxSetClusterNum = new System.Windows.Forms.TextBox();
            this.btn1ClusterOff = new System.Windows.Forms.Button();
            this.btnCalcEnergy = new System.Windows.Forms.Button();
            this.textBoxSetHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.checkBoxAllowGeneratePoints = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.labelHelpMap = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.labelRoute = new System.Windows.Forms.Label();
            this.pictBoxArea = new System.Windows.Forms.PictureBox();
            this.btnNearestNeighbour = new System.Windows.Forms.Button();
            this.btnFPPWR = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.btnLearningMode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnSpiralRoute.BackColor = System.Drawing.Color.DarkGray;
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
            // btnElasticNet
            // 
            this.btnElasticNet.BackColor = System.Drawing.Color.DarkGray;
            this.btnElasticNet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnElasticNet.Location = new System.Drawing.Point(1168, 363);
            this.btnElasticNet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElasticNet.Name = "btnElasticNet";
            this.btnElasticNet.Size = new System.Drawing.Size(319, 45);
            this.btnElasticNet.TabIndex = 30;
            this.btnElasticNet.Text = "Convex hull insertion (modified)";
            this.toolTip1.SetToolTip(this.btnElasticNet, "Build route like a rope\r\n1. creates an outer contour\r\n2. narrows the contour ever" +
        "y time");
            this.btnElasticNet.UseVisualStyleBackColor = false;
            this.btnElasticNet.Click += new System.EventHandler(this.btnClustersRoute_Click);
            // 
            // btnBruteForce
            // 
            this.btnBruteForce.BackColor = System.Drawing.Color.DarkGray;
            this.btnBruteForce.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBruteForce.Location = new System.Drawing.Point(1169, 412);
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
            // btn1ClusterOn
            // 
            this.btn1ClusterOn.BackColor = System.Drawing.Color.DarkGray;
            this.btn1ClusterOn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1ClusterOn.Location = new System.Drawing.Point(1169, 574);
            this.btn1ClusterOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1ClusterOn.Name = "btn1ClusterOn";
            this.btn1ClusterOn.Size = new System.Drawing.Size(156, 45);
            this.btn1ClusterOn.TabIndex = 32;
            this.btn1ClusterOn.Text = "Select cluster";
            this.toolTip1.SetToolTip(this.btn1ClusterOn, "Zoom and draw selected cluster");
            this.btn1ClusterOn.UseVisualStyleBackColor = false;
            this.btn1ClusterOn.Click += new System.EventHandler(this.btn1ClusterOn_Click);
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
            // btn1ClusterOff
            // 
            this.btn1ClusterOff.BackColor = System.Drawing.Color.Salmon;
            this.btn1ClusterOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1ClusterOff.Location = new System.Drawing.Point(1331, 574);
            this.btn1ClusterOff.Name = "btn1ClusterOff";
            this.btn1ClusterOff.Size = new System.Drawing.Size(40, 45);
            this.btn1ClusterOff.TabIndex = 35;
            this.btn1ClusterOff.Text = "×";
            this.toolTip1.SetToolTip(this.btn1ClusterOff, "Deselect cluster, draw map");
            this.btn1ClusterOff.UseVisualStyleBackColor = false;
            this.btn1ClusterOff.Click += new System.EventHandler(this.btn1ClusterOff_Click);
            // 
            // btnCalcEnergy
            // 
            this.btnCalcEnergy.BackColor = System.Drawing.Color.DarkGray;
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
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.btnLearningMode);
            this.panel.Controls.Add(this.labelEnergy);
            this.panel.Controls.Add(this.labelHelpMap);
            this.panel.Controls.Add(this.btnHelp);
            this.panel.Controls.Add(this.labelRoute);
            this.panel.Controls.Add(this.pictBoxArea);
            this.panel.Location = new System.Drawing.Point(0, -1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(888, 816);
            this.panel.TabIndex = 41;
            // 
            // labelHelpMap
            // 
            this.labelHelpMap.AutoSize = true;
            this.labelHelpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelpMap.Location = new System.Drawing.Point(80, 65);
            this.labelHelpMap.Name = "labelHelpMap";
            this.labelHelpMap.Size = new System.Drawing.Size(683, 200);
            this.labelHelpMap.TabIndex = 28;
            this.labelHelpMap.Text = resources.GetString("labelHelpMap.Text");
            this.labelHelpMap.Visible = false;
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
            this.btnNearestNeighbour.BackColor = System.Drawing.Color.DarkGray;
            this.btnNearestNeighbour.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNearestNeighbour.Location = new System.Drawing.Point(1168, 314);
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
            this.btnFPPWR.BackColor = System.Drawing.Color.DarkGray;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(894, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "[position, cluster] charge";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnergy.Location = new System.Drawing.Point(325, 760);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(120, 24);
            this.labelEnergy.TabIndex = 29;
            this.labelEnergy.Text = "___________";
            // 
            // btnLearningMode
            // 
            this.btnLearningMode.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLearningMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLearningMode.Location = new System.Drawing.Point(830, 102);
            this.btnLearningMode.Name = "btnLearningMode";
            this.btnLearningMode.Size = new System.Drawing.Size(42, 37);
            this.btnLearningMode.TabIndex = 30;
            this.btnLearningMode.Text = "L";
            this.toolTip1.SetToolTip(this.btnLearningMode, "Learning mode");
            this.btnLearningMode.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(829, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "S";
            this.toolTip1.SetToolTip(this.button1, "Statistic");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 817);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFPPWR);
            this.Controls.Add(this.btnNearestNeighbour);
            this.Controls.Add(this.checkBoxAllowGeneratePoints);
            this.Controls.Add(this.comboBoxConnectionType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSetHeight);
            this.Controls.Add(this.btnCalcEnergy);
            this.Controls.Add(this.btn1ClusterOff);
            this.Controls.Add(this.textBoxSetClusterNum);
            this.Controls.Add(this.btn1ClusterOn);
            this.Controls.Add(this.btnBruteForce);
            this.Controls.Add(this.btnElasticNet);
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
        private System.Windows.Forms.Button btnElasticNet;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.Button btn1ClusterOn;
        private System.Windows.Forms.TextBox textBoxSetClusterNum;
        private System.Windows.Forms.Button btn1ClusterOff;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label labelHelpMap;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLearningMode;
    }
}

