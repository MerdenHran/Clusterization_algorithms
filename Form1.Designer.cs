
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
            this.btnForel = new System.Windows.Forms.Button();
            this.btnGenPoints = new System.Windows.Forms.Button();
            this.btnKMeans = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSetSeedsCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxArea
            // 
            this.pictBoxArea.BackColor = System.Drawing.Color.White;
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
            this.textBoxSetPointsCount.Location = new System.Drawing.Point(1064, 217);
            this.textBoxSetPointsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetPointsCount.Name = "textBoxSetPointsCount";
            this.textBoxSetPointsCount.Size = new System.Drawing.Size(180, 32);
            this.textBoxSetPointsCount.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1061, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set points count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1061, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set radius:";
            // 
            // textBoxSetRadius
            // 
            this.textBoxSetRadius.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetRadius.Location = new System.Drawing.Point(1065, 277);
            this.textBoxSetRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetRadius.Name = "textBoxSetRadius";
            this.textBoxSetRadius.Size = new System.Drawing.Size(180, 32);
            this.textBoxSetRadius.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(1065, 150);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear field";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnForel
            // 
            this.btnForel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnForel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForel.Location = new System.Drawing.Point(1065, 64);
            this.btnForel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForel.Name = "btnForel";
            this.btnForel.Size = new System.Drawing.Size(180, 39);
            this.btnForel.TabIndex = 11;
            this.btnForel.Text = "Forel";
            this.btnForel.UseVisualStyleBackColor = false;
            this.btnForel.Click += new System.EventHandler(this.btnForel_Click);
            // 
            // btnGenPoints
            // 
            this.btnGenPoints.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenPoints.Location = new System.Drawing.Point(1065, 21);
            this.btnGenPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenPoints.Name = "btnGenPoints";
            this.btnGenPoints.Size = new System.Drawing.Size(180, 39);
            this.btnGenPoints.TabIndex = 10;
            this.btnGenPoints.Text = "Generate points";
            this.btnGenPoints.UseVisualStyleBackColor = false;
            this.btnGenPoints.Click += new System.EventHandler(this.btnGenPoints_Click);
            // 
            // btnKMeans
            // 
            this.btnKMeans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKMeans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKMeans.Location = new System.Drawing.Point(1065, 107);
            this.btnKMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKMeans.Name = "btnKMeans";
            this.btnKMeans.Size = new System.Drawing.Size(180, 39);
            this.btnKMeans.TabIndex = 17;
            this.btnKMeans.Text = "K-means";
            this.btnKMeans.UseVisualStyleBackColor = false;
            this.btnKMeans.Click += new System.EventHandler(this.btnKMeans_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1065, 440);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1064, 468);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 294);
            this.textBox3.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1064, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 51);
            this.button2.TabIndex = 20;
            this.button2.Text = "Draw route";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1061, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Set seeds count";
            // 
            // textBoxSetSeedsCount
            // 
            this.textBoxSetSeedsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSetSeedsCount.Location = new System.Drawing.Point(1064, 337);
            this.textBoxSetSeedsCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSetSeedsCount.Name = "textBoxSetSeedsCount";
            this.textBoxSetSeedsCount.Size = new System.Drawing.Size(180, 32);
            this.textBoxSetSeedsCount.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 775);
            this.Controls.Add(this.textBoxSetSeedsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKMeans);
            this.Controls.Add(this.textBoxSetPointsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetRadius);
            this.Controls.Add(this.btnClear);
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnForel;
        private System.Windows.Forms.Button btnGenPoints;
        private System.Windows.Forms.Button btnKMeans;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSetSeedsCount;
    }
}

