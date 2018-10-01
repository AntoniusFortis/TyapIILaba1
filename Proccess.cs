using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace GloryToSfedu
{
    class Proccess
    {
        // Затраченное время
        public long SpentTime { get; private set; }

        // Метод эксперимента
        public Bitmap Experiment(ChangerInfo changerinfo)
        {
            var changer = Changer.GetInstance(changerinfo);

            int threadscount = changerinfo.ThreadsAmount;

            // Пихаем объекты потока в массив (чтобы затраченное время на их создание не учитывались)
            var threads = new Thread[threadscount];

            for (int i = 0; i < threadscount; ++i)
                threads[i] = new Thread(Changer.ChangePixel);

            int maxheight = changerinfo.Picture.Height;
            // Получаем число строк для каждого потока
            int lines = maxheight / threadscount;

            // Объект измерения времени
            var stopwatcher = new Stopwatch();
            // Запусакем счётчик и потоки
            stopwatcher.Start();

            int starty = 0, endy = 0;
            foreach (var thread in threads)
            {
                endy += lines;
                if (endy >= maxheight)
                    endy = maxheight - 1;

                thread.Start(new ProccessInfo(starty, endy));

                starty = endy;
            }

            // Ставим в true флаг, который задерживает выполнение потоков, чтобы они запустились одновременно
            changer.SimultaneousLaunch.Set();

            // Ждём, пока не завершатся запущенные потоки
            changer.WaitAll.WaitOne();

            // Останавливаем счётчик и собираем инфу
            stopwatcher.Stop();

            // Закидываем затраченное время в переменную, из которой потом будет получено avg значение
            SpentTime += stopwatcher.ElapsedMilliseconds;

            // Возвращаем изменённую пикчу
            return changer.ResultBitmap;
        }
    }
}
