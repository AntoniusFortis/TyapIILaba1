using System;
using System.Drawing;
using System.Windows.Forms;

namespace GloryToSfedu
{
    public partial class MainForm : Form
    {
        private Proccess proc;
        private Bitmap srcBitmap;

        public MainForm()
        {
            InitializeComponent();
            srcBitmap = (Bitmap)VictimPictureBox.BackgroundImage;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            VictimPictureBox.BackgroundImage = srcBitmap;
            ResultChart.Series[0].Points.Clear();
            ResultTextBox.Text = string.Empty;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            proc = new Proccess(srcBitmap, (Bitmap)KhashcovskyPictureBox.BackgroundImage);
            int threadscount = (int)ThreadsNumeric.Value; 
            int maxtry = int.Parse(TriesNumeric.Value.ToString());

            int i;
            for (i = 0; i < maxtry; ++i)
            {
                VictimPictureBox.BackgroundImage = srcBitmap;
                proc.Experiment(threadscount);
                VictimPictureBox.BackgroundImage = proc.GetVictim();
            }

            double x = (double) ThreadsNumeric.Value;
            double y = proc.SpentTime / maxtry;

            var series = ResultChart.Series[0];
            for (i = 0; i < series.Points.Count; ++i)
            {
                if (series.Points[i].XValue == x)
                {
                    series.Points.RemoveAt(i);
                    break;
                }
            }
            series.Points.AddXY(x, y);
            ResultTextBox.Text += $"{x} threads ended in {y} ms.{Environment.NewLine}";
        }
    }
}
