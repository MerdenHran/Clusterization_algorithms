
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnGenPoints = new System.Windows.Forms.Button();
            this.btnKMeans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxArea
            // 
            this.pictBoxArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictBoxArea.Location = new System.Drawing.Point(12, 11);
            this.pictBoxArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBoxArea.Name = "pictBoxArea";
            this.pictBoxArea.Size = new System.Drawing.Size(796, 751);
            this.pictBoxArea.TabIndex = 1;
            this.pictBoxArea.TabStop = false;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.Location = new System.Drawing.Point(815, 13);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(230, 751);
            this.textBoxInfo.TabIndex = 9;
            // 
            // textBoxSetPointsCount
            // 
            this.textBoxSetPointsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetPointsCount.Location = new System.Drawing.Point(1065, 340);
            this.textBoxSetPointsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetPointsCount.Name = "textBoxSetPointsCount";
            this.textBoxSetPointsCount.Size = new System.Drawing.Size(180, 32);
            this.textBoxSetPointsCount.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1060, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set points count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1060, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set radius:";
            // 
            // textBoxSetRadius
            // 
            this.textBoxSetRadius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetRadius.Location = new System.Drawing.Point(1065, 266);
            this.textBoxSetRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetRadius.Name = "textBoxSetRadius";
            this.textBoxSetRadius.Size = new System.Drawing.Size(180, 32);
            this.textBoxSetRadius.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(1064, 175);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear field";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(1065, 67);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 50);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // btnGenPoints
            // 
            this.btnGenPoints.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenPoints.Location = new System.Drawing.Point(1065, 13);
            this.btnGenPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenPoints.Name = "btnGenPoints";
            this.btnGenPoints.Size = new System.Drawing.Size(180, 50);
            this.btnGenPoints.TabIndex = 10;
            this.btnGenPoints.Text = "Generate points";
            this.btnGenPoints.UseVisualStyleBackColor = false;
            this.btnGenPoints.Click += new System.EventHandler(this.btnGenPoints_Click);
            // 
            // btnKMeans
            // 
            this.btnKMeans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKMeans.Location = new System.Drawing.Point(1065, 121);
            this.btnKMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKMeans.Name = "btnKMeans";
            this.btnKMeans.Size = new System.Drawing.Size(180, 50);
            this.btnKMeans.TabIndex = 17;
            this.btnKMeans.Text = "K-means";
            this.btnKMeans.UseVisualStyleBackColor = false;
            this.btnKMeans.Click += new System.EventHandler(this.btnKMeans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 775);
            this.Controls.Add(this.btnKMeans);
            this.Controls.Add(this.textBoxSetPointsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetRadius);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnGenPoints;
        private System.Windows.Forms.Button btnKMeans;
    }
}

