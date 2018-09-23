using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace GloryToSfedu
{
    // Класс, содержащий инфу для changepixel
    class ProccessInfo
    {
        // Текущие коордианты по X и Y
        public volatile int X;
        public volatile int Y;
        // Кол-во запущенных потоков
        public volatile int ThreadsRunning;

        // Максимальная высота и ширина изображения 
        public int Height;
        public int Width;
        // Кол-во пикселей, над которыми колдует каждый поток
        public int PixelAmount;

        // Списки пикселей обоих изображений 
        public List<Color> FirstListColors;
        public List<Color> SecListColors;
        // Флаг для одновременного старта работы потоков (хотя бы с точки зрения кода)
        public ManualResetEvent SimultaneousLaunch = new ManualResetEvent(false);
        // Флаг для на ожидание выполнения работы всех потоков
        public ManualResetEvent WaitAll = new ManualResetEvent(false);

        // Финальное изображение
        public Bitmap ResultBitmap;
    }

    class Proccess
    {
        // Затраченное время
        public long SpentTime { get; set; }

        // Метод эксперимента
        public Bitmap Experiment(int threadscount, int maxheight, int maxwidth, ref List<Color> firstlist, ref List<Color> secondlist)
        {
            int i;

            // Пихаем объекты потока в массив (чтобы затраченное время на их создание не учитывались)
            var threads = new Thread[threadscount];
            for (i = 0; i < threadscount; ++i)
            {
                threads[i] = new Thread(ChangePixel);
            }
            
            // Получаем число пикселей для каждого потока
            int pixels = maxheight * maxwidth / threadscount;

            // Создаём структуру с инфой для changepixel
            var procinfo = new ProccessInfo
            {
                Height = maxheight,
                Width = maxwidth,
                ThreadsRunning = threadscount,
                PixelAmount = pixels,
                FirstListColors = firstlist,
                SecListColors = secondlist,
                ResultBitmap = new Bitmap(maxwidth, maxheight)
            };

            // Объект измерения времени
            var stopwatcher = new Stopwatch();
            // Запусакем счётчик и потоки
            stopwatcher.Start();
            for (i = 0; i < threadscount; ++i)
            {
                threads[i].Start(procinfo);
            }

            // Ставим в true флаг, который задерживает выполнение потоков, чтобы они запустились одновременно
            procinfo.SimultaneousLaunch.Set();

            // Ждём, пока не завершатся запущенные потоки
            procinfo.WaitAll.WaitOne();

            // Останавливаем счётчик и собираем инфу
            stopwatcher.Stop();

            // Закидываем затраченное время в переменную, из которой потом будет получено avg значение
            SpentTime += stopwatcher.ElapsedMilliseconds;

            // Возвращаем изменённую пикчу
            return procinfo.ResultBitmap;
        }

        // Метод изменения пикселей
        private static void ChangePixel(object obj)
        {
            var info = (ProccessInfo)obj;

            // Ждём пока не дадут разрешения начать работу
            info.SimultaneousLaunch.WaitOne();

            var availPixels = info.PixelAmount;

            ref int currentX = ref info.X;
            ref int currentY = ref info.Y;
            ref int threadsamount = ref info.ThreadsRunning;

            int maxheight = info.Height;
            int maxwidth = info.Width;

            var firstlist = info.FirstListColors;
            var seclist = info.SecListColors;

            while (availPixels > 0 && currentY < maxheight)
            {
                int index = maxwidth * currentY + currentX;

                var clrpixel1 = firstlist[index];
                var clrpixel2 = seclist[index];
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
                lock (info.ResultBitmap)
                    info.ResultBitmap.SetPixel(currentX, currentY, newColor);

                // Проверки на превышении ширины
                if (currentX >= maxwidth - 1)
                {
                    Interlocked.Increment(ref currentY);
                    Interlocked.Exchange(ref currentX, 0);
                }
                else
                {
                    Interlocked.Increment(ref currentX);
                }
                --availPixels;
                Thread.Sleep(0);
            }
            Interlocked.Decrement(ref threadsamount);

            // Если мы последний поток, говорим, что все потоки выполнились
            if (threadsamount == 0)
            {
                info.WaitAll.Set();
            }
        }
    }
}
