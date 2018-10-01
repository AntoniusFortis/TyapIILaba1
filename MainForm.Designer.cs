namespace GloryToSfedu
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VictimPictureBox = new System.Windows.Forms.PictureBox();
            this.KhashcovskyPictureBox = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ThreadsNumeric = new System.Windows.Forms.NumericUpDown();
            this.TriesNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VictimPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhashcovskyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriesNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VictimPictureBox
            // 
            this.VictimPictureBox.BackgroundImage = global::GloryToSfedu.Properties.Resources._222;
            this.VictimPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VictimPictureBox.Location = new System.Drawing.Point(9, 18);
            this.VictimPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.VictimPictureBox.Name = "VictimPictureBox";
            this.VictimPictureBox.Size = new System.Drawing.Size(285, 352);
            this.VictimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VictimPictureBox.TabIndex = 0;
            this.VictimPictureBox.TabStop = false;
            // 
            // KhashcovskyPictureBox
            // 
            this.KhashcovskyPictureBox.BackgroundImage = global::GloryToSfedu.Properties.Resources.per_id__3001849;
            this.KhashcovskyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KhashcovskyPictureBox.Location = new System.Drawing.Point(303, 18);
            this.KhashcovskyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.KhashcovskyPictureBox.Name = "KhashcovskyPictureBox";
            this.KhashcovskyPictureBox.Size = new System.Drawing.Size(285, 352);
            this.KhashcovskyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KhashcovskyPictureBox.TabIndex = 1;
            this.KhashcovskyPictureBox.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.StartBtn.FlatAppearance.BorderSize = 3;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(64, 188);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(241, 42);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Старт эксперимента";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ResultChart
            // 
            this.ResultChart.BackColor = System.Drawing.Color.Transparent;
            this.ResultChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.ResultChart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.ResultChart.BorderlineColor = System.Drawing.Color.DimGray;
            this.ResultChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea3);
            this.ResultChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Name = "Legend1";
            this.ResultChart.Legends.Add(legend3);
            this.ResultChart.Location = new System.Drawing.Point(269, 396);
            this.ResultChart.Margin = new System.Windows.Forms.Padding(4);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "threads/ms";
            series3.Name = "Series1";
            this.ResultChart.Series.Add(series3);
            this.ResultChart.Size = new System.Drawing.Size(715, 271);
            this.ResultChart.TabIndex = 5;
            // 
            // ThreadsNumeric
            // 
            this.ThreadsNumeric.Location = new System.Drawing.Point(195, 75);
            this.ThreadsNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.ThreadsNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ThreadsNumeric.Name = "ThreadsNumeric";
            this.ThreadsNumeric.Size = new System.Drawing.Size(97, 22);
            this.ThreadsNumeric.TabIndex = 7;
            this.ThreadsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TriesNumeric
            // 
            this.TriesNumeric.Location = new System.Drawing.Point(195, 118);
            this.TriesNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.TriesNumeric.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.TriesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TriesNumeric.Name = "TriesNumeric";
            this.TriesNumeric.Size = new System.Drawing.Size(97, 22);
            this.TriesNumeric.TabIndex = 8;
            this.TriesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VictimPictureBox);
            this.groupBox1.Controls.Add(this.KhashcovskyPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(600, 380);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TriesNumeric);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ThreadsNumeric);
            this.groupBox2.Controls.Add(this.StartBtn);
            this.groupBox2.Location = new System.Drawing.Point(625, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(359, 380);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ClearBtn.FlatAppearance.BorderSize = 3;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(64, 256);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(241, 42);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Очистить результаты";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Число повторений :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Макс. степень потоков:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.Location = new System.Drawing.Point(15, 396);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(245, 270);
            this.ResultTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 676);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тяп 1 лаба";
            ((System.ComponentModel.ISupportInitialize)(this.VictimPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhashcovskyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriesNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VictimPictureBox;
        private System.Windows.Forms.PictureBox KhashcovskyPictureBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        private System.Windows.Forms.NumericUpDown ThreadsNumeric;
        private System.Windows.Forms.NumericUpDown TriesNumeric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ClearBtn;
    }
}

