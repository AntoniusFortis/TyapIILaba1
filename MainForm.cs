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
        private void StartBtn_Click(object sender, EventArgs e)
        {
            // Фигачим массивы пикселей для двух изображений
            SetListColors(_firstBitmap, (Bitmap)KhashcovskyPictureBox.BackgroundImage, out var sourceColors, out var khashColors);

            var proc = new Proccess();

            // Кол-во потоков
            int threadscount = (int)ThreadsNumeric.Value; 
            // Кол-во повторений эксперимента
            int maxtry = (int)TriesNumeric.Value;

            int i;
            // Фигачим эксперимент по кол-во его повторений
            for (i = 0; i < maxtry; ++i)
            {
                // Возвращаем исходную пикчу
                VictimPictureBox.BackgroundImage = _firstBitmap;
                // Получаем изменённую пикчу и выводим её
                var newpic = proc.Experiment(threadscount, _firstBitmap.Height, _firstBitmap.Width, ref sourceColors, ref khashColors);
                VictimPictureBox.BackgroundImage = newpic;
            }

            // Работаем с графиком
            double x = (double) ThreadsNumeric.Value;
            double y = proc.SpentTime / maxtry;

            var series = ResultChart.Series[0];
            for (i = 0; i < series.Points.Count; ++i)
            {
                if (series.Points[i].XValue == threadscount)
                {
                    series.Points.RemoveAt(i);
                    break;
                }
            }
            series.Points.AddXY(x, y);
            ResultTextBox.Text += $@"{x} threads ended in {y} ms.{Environment.NewLine}";

            // Заставим garbage collector принудительно убрать мусор (ну, на всякий случай)
            GC.Collect();
        }
    }
}
