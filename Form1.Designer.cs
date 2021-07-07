
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
            this.pictBoxArea = new System.Windows.Forms.PictureBox();
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
            this.btnCMeans = new System.Windows.Forms.Button();
            this.labelRoute = new System.Windows.Forms.Label();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnSpiralRoute = new System.Windows.Forms.Button();
            this.btnClustersRoute = new System.Windows.Forms.Button();
            this.btnBruteForce = new System.Windows.Forms.Button();
            this.btn1ClusterOn = new System.Windows.Forms.Button();
            this.textBoxSetClusterNum = new System.Windows.Forms.TextBox();
            this.pictBox1Cluster = new System.Windows.Forms.PictureBox();
            this.btn1ClusterOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox1Cluster)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxArea
            // 
            this.pictBoxArea.BackColor = System.Drawing.Color.White;
            this.pictBoxArea.Enabled = false;
            this.pictBoxArea.Location = new System.Drawing.Point(12, 11);
            this.pictBoxArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBoxArea.Name = "pictBoxArea";
            this.pictBoxArea.Size = new System.Drawing.Size(796, 751);
            this.pictBoxArea.TabIndex = 1;
            this.pictBoxArea.TabStop = false;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.AcceptsReturn = true;
            this.textBoxInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(815, 13);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(230, 751);
            this.textBoxInfo.TabIndex = 9;
            // 
            // textBoxSetPointsCount
            // 
            this.textBoxSetPointsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetPointsCount.Location = new System.Drawing.Point(1244, 97);
            this.textBoxSetPointsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetPointsCount.Name = "textBoxSetPointsCount";
            this.textBoxSetPointsCount.Size = new System.Drawing.Size(145, 32);
            this.textBoxSetPointsCount.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1070, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set points count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1069, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set radius:";
            // 
            // textBoxSetRadius
            // 
            this.textBoxSetRadius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetRadius.Location = new System.Drawing.Point(1073, 275);
            this.textBoxSetRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetRadius.Name = "textBoxSetRadius";
            this.textBoxSetRadius.Size = new System.Drawing.Size(137, 32);
            this.textBoxSetRadius.TabIndex = 13;
            // 
            // btnForel
            // 
            this.btnForel.BackColor = System.Drawing.Color.DarkGray;
            this.btnForel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForel.Location = new System.Drawing.Point(1235, 268);
            this.btnForel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForel.Name = "btnForel";
            this.btnForel.Size = new System.Drawing.Size(154, 45);
            this.btnForel.TabIndex = 11;
            this.btnForel.Text = "Forel";
            this.btnForel.UseVisualStyleBackColor = false;
            this.btnForel.Click += new System.EventHandler(this.btnForel_Click);
            // 
            // btnGenPoints
            // 
            this.btnGenPoints.BackColor = System.Drawing.Color.DarkGray;
            this.btnGenPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenPoints.Location = new System.Drawing.Point(1072, 24);
            this.btnGenPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenPoints.Name = "btnGenPoints";
            this.btnGenPoints.Size = new System.Drawing.Size(317, 52);
            this.btnGenPoints.TabIndex = 10;
            this.btnGenPoints.Text = "Sensor network detection";
            this.btnGenPoints.UseVisualStyleBackColor = false;
            this.btnGenPoints.Click += new System.EventHandler(this.btnGenPoints_Click);
            this.btnGenPoints.MouseLeave += new System.EventHandler(this.btnGenPoints_MouseLeave);
            this.btnGenPoints.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGenPoints_MouseMove);
            // 
            // btnKMeans
            // 
            this.btnKMeans.BackColor = System.Drawing.Color.DarkGray;
            this.btnKMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKMeans.Location = new System.Drawing.Point(1235, 158);
            this.btnKMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKMeans.Name = "btnKMeans";
            this.btnKMeans.Size = new System.Drawing.Size(154, 45);
            this.btnKMeans.TabIndex = 17;
            this.btnKMeans.Text = "k-means++";
            this.btnKMeans.UseVisualStyleBackColor = false;
            this.btnKMeans.Click += new System.EventHandler(this.btnKMeans_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1069, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Set seeds count";
            // 
            // textBoxSetSeedsCount
            // 
            this.textBoxSetSeedsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetSeedsCount.Location = new System.Drawing.Point(1072, 194);
            this.textBoxSetSeedsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetSeedsCount.Name = "textBoxSetSeedsCount";
            this.textBoxSetSeedsCount.Size = new System.Drawing.Size(137, 32);
            this.textBoxSetSeedsCount.TabIndex = 24;
            // 
            // btnCMeans
            // 
            this.btnCMeans.BackColor = System.Drawing.Color.DarkGray;
            this.btnCMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCMeans.Location = new System.Drawing.Point(1235, 207);
            this.btnCMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCMeans.Name = "btnCMeans";
            this.btnCMeans.Size = new System.Drawing.Size(154, 45);
            this.btnCMeans.TabIndex = 25;
            this.btnCMeans.Text = "c-means";
            this.btnCMeans.UseVisualStyleBackColor = false;
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoute.Location = new System.Drawing.Point(24, 727);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(0, 24);
            this.labelRoute.TabIndex = 26;
            // 
            // btnRoute
            // 
            this.btnRoute.BackColor = System.Drawing.Color.DarkGray;
            this.btnRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoute.Location = new System.Drawing.Point(1072, 450);
            this.btnRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(127, 45);
            this.btnRoute.TabIndex = 28;
            this.btnRoute.Text = "All route";
            this.btnRoute.UseVisualStyleBackColor = false;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnSpiralRoute
            // 
            this.btnSpiralRoute.BackColor = System.Drawing.Color.DarkGray;
            this.btnSpiralRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpiralRoute.Location = new System.Drawing.Point(1203, 450);
            this.btnSpiralRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpiralRoute.Name = "btnSpiralRoute";
            this.btnSpiralRoute.Size = new System.Drawing.Size(188, 45);
            this.btnSpiralRoute.TabIndex = 29;
            this.btnSpiralRoute.Text = "All spiral route";
            this.btnSpiralRoute.UseVisualStyleBackColor = false;
            this.btnSpiralRoute.Click += new System.EventHandler(this.btnSpiralRoute_Click);
            // 
            // btnClustersRoute
            // 
            this.btnClustersRoute.BackColor = System.Drawing.Color.DarkGray;
            this.btnClustersRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClustersRoute.Location = new System.Drawing.Point(1072, 341);
            this.btnClustersRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClustersRoute.Name = "btnClustersRoute";
            this.btnClustersRoute.Size = new System.Drawing.Size(319, 45);
            this.btnClustersRoute.TabIndex = 30;
            this.btnClustersRoute.Text = "Draw route by Elastic Net\r\n";
            this.btnClustersRoute.UseVisualStyleBackColor = false;
            this.btnClustersRoute.Click += new System.EventHandler(this.btnClustersRoute_Click);
            // 
            // btnBruteForce
            // 
            this.btnBruteForce.BackColor = System.Drawing.Color.DarkGray;
            this.btnBruteForce.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBruteForce.Location = new System.Drawing.Point(1072, 396);
            this.btnBruteForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBruteForce.Name = "btnBruteForce";
            this.btnBruteForce.Size = new System.Drawing.Size(319, 45);
            this.btnBruteForce.TabIndex = 31;
            this.btnBruteForce.Text = "Draw route by Brute-force";
            this.btnBruteForce.UseVisualStyleBackColor = false;
            this.btnBruteForce.Click += new System.EventHandler(this.btnBruteForce_Click);
            // 
            // btn1ClusterOn
            // 
            this.btn1ClusterOn.BackColor = System.Drawing.Color.DarkGray;
            this.btn1ClusterOn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1ClusterOn.Location = new System.Drawing.Point(1073, 508);
            this.btn1ClusterOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1ClusterOn.Name = "btn1ClusterOn";
            this.btn1ClusterOn.Size = new System.Drawing.Size(156, 45);
            this.btn1ClusterOn.TabIndex = 32;
            this.btn1ClusterOn.Text = "Select cluster";
            this.btn1ClusterOn.UseVisualStyleBackColor = false;
            this.btn1ClusterOn.Click += new System.EventHandler(this.btn1ClusterOn_Click);
            // 
            // textBoxSetClusterNum
            // 
            this.textBoxSetClusterNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetClusterNum.Location = new System.Drawing.Point(1283, 515);
            this.textBoxSetClusterNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetClusterNum.Name = "textBoxSetClusterNum";
            this.textBoxSetClusterNum.Size = new System.Drawing.Size(106, 32);
            this.textBoxSetClusterNum.TabIndex = 33;
            // 
            // pictBox1Cluster
            // 
            this.pictBox1Cluster.BackColor = System.Drawing.Color.LightCyan;
            this.pictBox1Cluster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBox1Cluster.Enabled = false;
            this.pictBox1Cluster.Location = new System.Drawing.Point(158, 11);
            this.pictBox1Cluster.Name = "pictBox1Cluster";
            this.pictBox1Cluster.Size = new System.Drawing.Size(650, 643);
            this.pictBox1Cluster.TabIndex = 34;
            this.pictBox1Cluster.TabStop = false;
            this.pictBox1Cluster.Visible = false;
            // 
            // btn1ClusterOff
            // 
            this.btn1ClusterOff.Location = new System.Drawing.Point(1235, 511);
            this.btn1ClusterOff.Name = "btn1ClusterOff";
            this.btn1ClusterOff.Size = new System.Drawing.Size(42, 42);
            this.btn1ClusterOff.TabIndex = 35;
            this.btn1ClusterOff.Text = "×";
            this.btn1ClusterOff.UseVisualStyleBackColor = true;
            this.btn1ClusterOff.Click += new System.EventHandler(this.btn1ClusterOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 775);
            this.Controls.Add(this.btn1ClusterOff);
            this.Controls.Add(this.pictBox1Cluster);
            this.Controls.Add(this.textBoxSetClusterNum);
            this.Controls.Add(this.btn1ClusterOn);
            this.Controls.Add(this.btnBruteForce);
            this.Controls.Add(this.btnClustersRoute);
            this.Controls.Add(this.btnSpiralRoute);
            this.Controls.Add(this.btnRoute);
            this.Controls.Add(this.labelRoute);
            this.Controls.Add(this.btnCMeans);
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
            this.Controls.Add(this.pictBoxArea);
            this.Name = "Form1";
            this.Text = "Clusterization algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox1Cluster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxArea;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxSetPointsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSetRadius;
        private System.Windows.Forms.Button btnForel;
        private System.Windows.Forms.Button btnGenPoints;
        private System.Windows.Forms.Button btnKMeans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSetSeedsCount;
        private System.Windows.Forms.Button btnCMeans;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnSpiralRoute;
        private System.Windows.Forms.Button btnClustersRoute;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.Button btn1ClusterOn;
        private System.Windows.Forms.TextBox textBoxSetClusterNum;
        private System.Windows.Forms.PictureBox pictBox1Cluster;
        private System.Windows.Forms.Button btn1ClusterOff;
    }
}

