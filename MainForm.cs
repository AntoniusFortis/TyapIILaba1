using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GloryToSfedu
{
    public partial class MainForm : Form
    {
        private readonly Bitmap _firstBitmap;

        public MainForm()
        {
            InitializeComponent();
            _firstBitmap = (Bitmap)VictimPictureBox.BackgroundImage;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            VictimPictureBox.BackgroundImage = _firstBitmap;
            ResultChart.Series[0].Points.Clear();
            ResultTextBox.Text = string.Empty;
        }

        private void SetListColors(Bitmap first, Bitmap second, out List<Color> firstList, out List<Color> secList)
        {
            int maxHeight = first.Height;
            int maxWidth = first.Width;

            firstList = new List<Color>(maxHeight * maxWidth);
            secList = new List<Color>(maxHeight * maxWidth);

            // Заполняем списки цветов
            for (int y = 0; y < maxHeight; ++y)
            {
                for (int x = 0; x < maxWidth; ++x)
                {
                    firstList.Add(first.GetPixel(x, y));
                    secList.Add(second.GetPixel(x, y));
                }
            }
        }


        private void Btns_Enable(bool value)
        {
            ClearBtn.Enabled = value;
            StartBtn.Enabled = value;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Btns_Enable(false);

            for (int i=0; i<=ThreadsNumeric.Value; i++)
                StartAction((int)Math.Pow(2.0, i));

            Btns_Enable(true);
        }

        private void StartAction(int num)
        {
            // Фигачим массивы пикселей для двух изображений
            SetListColors(_firstBitmap, (Bitmap)KhashcovskyPictureBox.BackgroundImage, out var sourceColors, out var khashColors);

            var proc = new Proccess();

            // Кол-во потоков
            int threadscount = num;

            // Кол-во повторений эксперимента
            int maxtry = (int)TriesNumeric.Value;

            // Заполняем структуру с инфой
            var ci = new ChangerInfo(new Bitmap(_firstBitmap.Width, _firstBitmap.Height), threadscount, ref sourceColors, ref khashColors);

            // Фигачим эксперимент по кол-во его повторений
            for (int i = 0; i < maxtry; ++i)
            {
                // Возвращаем исходную пикчу
                VictimPictureBox.BackgroundImage = _firstBitmap;
                // Получаем изменённую пикчу и выводим её
                var newpic = proc.Experiment(ci);
                VictimPictureBox.BackgroundImage = newpic;
            }

            // Работаем с графиком
            double y = proc.SpentTime / maxtry;

            var series = ResultChart.Series[0];
            for (int i = 0; i < series.Points.Count; ++i)
                if (series.Points[i].XValue == threadscount)
                {
                    series.Points.RemoveAt(i);
                    break;
                }

            series.Points.AddXY(threadscount, y);
            ResultTextBox.Text += $@"{threadscount} threads ended in {y} ms.{Environment.NewLine}";
        }
    }
}
