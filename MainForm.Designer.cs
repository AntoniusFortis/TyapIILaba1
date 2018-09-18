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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.VictimPictureBox.Location = new System.Drawing.Point(7, 15);
            this.VictimPictureBox.Name = "VictimPictureBox";
            this.VictimPictureBox.Size = new System.Drawing.Size(214, 286);
            this.VictimPictureBox.TabIndex = 0;
            this.VictimPictureBox.TabStop = false;
            // 
            // KhashcovskyPictureBox
            // 
            this.KhashcovskyPictureBox.BackgroundImage = global::GloryToSfedu.Properties.Resources.per_id__3001849;
            this.KhashcovskyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KhashcovskyPictureBox.Location = new System.Drawing.Point(227, 15);
            this.KhashcovskyPictureBox.Name = "KhashcovskyPictureBox";
            this.KhashcovskyPictureBox.Size = new System.Drawing.Size(214, 286);
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
            this.StartBtn.Location = new System.Drawing.Point(48, 153);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(181, 34);
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
            chartArea1.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea1);
            this.ResultChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.ResultChart.Legends.Add(legend1);
            this.ResultChart.Location = new System.Drawing.Point(202, 322);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "threads/ms";
            series1.Name = "Series1";
            this.ResultChart.Series.Add(series1);
            this.ResultChart.Size = new System.Drawing.Size(536, 220);
            this.ResultChart.TabIndex = 5;
            // 
            // ThreadsNumeric
            // 
            this.ThreadsNumeric.Location = new System.Drawing.Point(146, 61);
            this.ThreadsNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ThreadsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThreadsNumeric.Name = "ThreadsNumeric";
            this.ThreadsNumeric.Size = new System.Drawing.Size(73, 20);
            this.ThreadsNumeric.TabIndex = 7;
            this.ThreadsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TriesNumeric
            // 
            this.TriesNumeric.Location = new System.Drawing.Point(146, 96);
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
            this.TriesNumeric.Size = new System.Drawing.Size(73, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 309);
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
            this.groupBox2.Location = new System.Drawing.Point(469, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 309);
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
            this.ClearBtn.Location = new System.Drawing.Point(48, 208);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(181, 34);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Очистить результаты";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Число повторений :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число потоков:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.Location = new System.Drawing.Point(11, 322);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(185, 220);
            this.ResultTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 549);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

