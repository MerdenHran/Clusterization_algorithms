
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
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).BeginInit();
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
            this.textBoxSetPointsCount.Location = new System.Drawing.Point(1075, 291);
            this.textBoxSetPointsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetPointsCount.Name = "textBoxSetPointsCount";
            this.textBoxSetPointsCount.Size = new System.Drawing.Size(180, 32);
            this.textBoxSetPointsCount.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1072, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set points count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1071, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set radius:";
            // 
            // textBoxSetRadius
            // 
            this.textBoxSetRadius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetRadius.Location = new System.Drawing.Point(1075, 205);
            this.textBoxSetRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetRadius.Name = "textBoxSetRadius";
            this.textBoxSetRadius.Size = new System.Drawing.Size(137, 32);
            this.textBoxSetRadius.TabIndex = 13;
            // 
            // btnForel
            // 
            this.btnForel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnForel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForel.Location = new System.Drawing.Point(1237, 198);
            this.btnForel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForel.Name = "btnForel";
            this.btnForel.Size = new System.Drawing.Size(138, 45);
            this.btnForel.TabIndex = 11;
            this.btnForel.Text = "Forel";
            this.btnForel.UseVisualStyleBackColor = false;
            this.btnForel.Click += new System.EventHandler(this.btnForel_Click);
            // 
            // btnGenPoints
            // 
            this.btnGenPoints.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenPoints.Location = new System.Drawing.Point(1074, 22);
            this.btnGenPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenPoints.Name = "btnGenPoints";
            this.btnGenPoints.Size = new System.Drawing.Size(301, 52);
            this.btnGenPoints.TabIndex = 10;
            this.btnGenPoints.Text = "Sensor network detection";
            this.btnGenPoints.UseVisualStyleBackColor = false;
            this.btnGenPoints.Click += new System.EventHandler(this.btnGenPoints_Click);
            // 
            // btnKMeans
            // 
            this.btnKMeans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKMeans.Location = new System.Drawing.Point(1237, 88);
            this.btnKMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKMeans.Name = "btnKMeans";
            this.btnKMeans.Size = new System.Drawing.Size(138, 45);
            this.btnKMeans.TabIndex = 17;
            this.btnKMeans.Text = "k-means++";
            this.btnKMeans.UseVisualStyleBackColor = false;
            this.btnKMeans.Click += new System.EventHandler(this.btnKMeans_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1071, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Set seeds count";
            // 
            // textBoxSetSeedsCount
            // 
            this.textBoxSetSeedsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetSeedsCount.Location = new System.Drawing.Point(1074, 124);
            this.textBoxSetSeedsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetSeedsCount.Name = "textBoxSetSeedsCount";
            this.textBoxSetSeedsCount.Size = new System.Drawing.Size(137, 32);
            this.textBoxSetSeedsCount.TabIndex = 24;
            // 
            // btnCMeans
            // 
            this.btnCMeans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCMeans.Location = new System.Drawing.Point(1237, 137);
            this.btnCMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCMeans.Name = "btnCMeans";
            this.btnCMeans.Size = new System.Drawing.Size(138, 45);
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
            this.btnRoute.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoute.Location = new System.Drawing.Point(1076, 392);
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
            this.btnSpiralRoute.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSpiralRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpiralRoute.Location = new System.Drawing.Point(1209, 392);
            this.btnSpiralRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpiralRoute.Name = "btnSpiralRoute";
            this.btnSpiralRoute.Size = new System.Drawing.Size(186, 45);
            this.btnSpiralRoute.TabIndex = 29;
            this.btnSpiralRoute.Text = "All spiral route";
            this.btnSpiralRoute.UseVisualStyleBackColor = false;
            this.btnSpiralRoute.Click += new System.EventHandler(this.btnSpiralRoute_Click);
            // 
            // btnClustersRoute
            // 
            this.btnClustersRoute.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClustersRoute.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClustersRoute.Location = new System.Drawing.Point(1076, 343);
            this.btnClustersRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClustersRoute.Name = "btnClustersRoute";
            this.btnClustersRoute.Size = new System.Drawing.Size(319, 45);
            this.btnClustersRoute.TabIndex = 30;
            this.btnClustersRoute.Text = "Draw route by clusters";
            this.btnClustersRoute.UseVisualStyleBackColor = false;
            this.btnClustersRoute.Click += new System.EventHandler(this.btnClustersRoute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 775);
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
    }
}

