using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace GloryToSfedu
{
    class Proccess
    {
        // Затраченное время
        public long SpentTime { get; set; } = 0;

        // Затраченное время
        private Bitmap sourceBitmap;
        // Изображение в которое заносится результат работы потоков
        private static Bitmap victimBitmap;
        // Координаты текущего пикселя
        private static volatile int currentY = 0, currentX = 0;
        // Кол-во пикселей по высоте и ширине 
        private static int maxHeight, maxWidth;
        // Счетчик завершенных потоков
        private static volatile int stoppedthreads = 0;
        // Список пикселей изображений
        private static List<Color> sourceColors, khashColors;
        // Флаг для одновременного запуска работы потоков
        private static ManualResetEvent simultaneousLaunch = new ManualResetEvent(false);
        // Объект измерения времени
        // (он тут для того, чтобы не создавать его в коде каждый раз)
        private Stopwatch stopwatcher = new Stopwatch();

        public Proccess(Bitmap bmp1, Bitmap bmp2)
        {
            maxHeight = bmp1.Height;
            maxWidth = bmp1.Width;

            sourceColors = new List<Color>(maxHeight * maxWidth);
            khashColors = new List<Color>(maxHeight * maxWidth);

            // Заполняем списки цветов
            int y, x;
            for (y = 0; y < maxHeight; ++y)
            {
                for (x = 0; x < maxWidth; ++x)
                {
                    sourceColors.Add(bmp1.GetPixel(x, y));
                    khashColors.Add(bmp2.GetPixel(x, y));
                }
            }

            sourceBitmap = bmp1;
        }

        // Метод эксперимента
        public void Experiment(int threadscount)
        {
            int i;

            victimBitmap = new Bitmap(sourceBitmap);

            // Пихаем объекты потока в массив (чтобы затраченное время на их создания не учитывались)
            var threads = new Thread[threadscount];
            for (i = 0; i < threadscount; ++i)
            {
                threads[i] = new Thread(ChangePixel);
            }

            // Получаем число пикселей для каждого потока
            int pixels = getAvailPixels(threadscount);

            // Запусакем счётчик и потоки
            stopwatcher.Start();
            for (i = 0; i < threadscount; ++i)
            {
                threads[i].Start(pixels);
            }

            // Ставим в true флаг, который задерживает выполнение потоков, чтобы они запустились одновременно
            simultaneousLaunch.Set();
            
            // Ждём, пока не завершатся запущенные потоки
            while (stoppedthreads < threadscount)
                Thread.Sleep(1);

            // Останавливаем счётчик и собираем инфу
            stopwatcher.Stop();
            SpentTime += stopwatcher.ElapsedMilliseconds;

            // Обнуляем все счётчики и флаги
            stopwatcher.Reset();
            simultaneousLaunch.Reset();
            stoppedthreads = 0;
            currentX = 0;
            currentY = 0;
        }

        // Метод изменения пикселей
        private static void ChangePixel(object info)
        {
            // Ждём пока не дадут разрешения начать работу
            simultaneousLaunch.WaitOne();
            // Получаем кол-во пикселей на изменение данным потоком
            int avail_pixels = (int)info;

            while (avail_pixels > 0 && currentY < maxHeight)
            {
                int index = maxWidth * currentY + currentX;

                var clrpixel1 = khashColors[index];
                var clrpixel2 = sourceColors[index];
                // Анонимный readonly тип, в который вбиваем argb палитру пикселей обоих изображений
                // и колдуем над ними
                var newcolor = new
                {
                    Alpha = clrpixel1.A | clrpixel2.A / 2,
                    Red = clrpixel1.R & clrpixel2.R / 2,
                    Green = clrpixel1.G | clrpixel2.G / 2,
                    Blue = clrpixel1.B >> clrpixel2.B / 3
                };

                // Получаем цвет из полученных байтов
                var newColor = Color.FromArgb(newcolor.Alpha, newcolor.Red, newcolor.Green, newcolor.Blue);

                // Меняем цвет пикселя
                lock (victimBitmap)
                    victimBitmap.SetPixel(currentX, currentY, newColor);

                // Проверки на превышении ширины
                if (currentX >= maxWidth - 1)
                {
                    ++currentY;
                    currentX = 0;
                }
                else
                {
                    ++currentX;
                }
                --avail_pixels;
                Thread.Sleep(0);
            }
            ++stoppedthreads;
        }

        // Метод получения кол-во пикселей
        private int getAvailPixels(int threadscount)
        {
            return maxHeight * maxWidth / threadscount;
        }

        // Метод передачи victimBitmap во вне
        public Bitmap GetVictim()
        {
            return victimBitmap;
        }
    }
}
