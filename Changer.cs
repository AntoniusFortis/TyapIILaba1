using System.Drawing;
using System.Threading;
using ColorList = System.Collections.Generic.List<System.Drawing.Color>;

namespace GloryToSfedu
{
    public class Changer
    {
        private static Changer _instance;

        private Changer(ChangerInfo changerinfo)
        {
            LoadInfo(changerinfo);
        }

        public static Changer GetInstance(ChangerInfo changerinfo)
        {
            if (_instance == null)
                _instance = new Changer(changerinfo);
            else
                _instance.LoadInfo(changerinfo);

            return _instance;
        }

        // Списки пикселей обоих изображений 
        private ColorList _firstListColors;
        private ColorList _secListColors;

        // Максимальная ширина изображения 
        private int _width;

        // Кол-во запущенных потоков
        private int _threadsRunning;

        // Флаг для одновременного старта работы потоков (хотя бы с точки зрения кода)
        public ManualResetEvent SimultaneousLaunch;
        // Флаг для на ожидание выполнения работы всех потоков
        public ManualResetEvent WaitAll;

        // Финальное изображение
        public Bitmap ResultBitmap { get; private set; }

        private void LoadInfo(ChangerInfo changerInfo)
        {
            ResultBitmap = changerInfo.Picture;
            _threadsRunning = changerInfo.ThreadsAmount;
            _firstListColors = changerInfo.FirstList;
            _secListColors = changerInfo.SecondList;
            _width = ResultBitmap.Width;
            SimultaneousLaunch = new ManualResetEvent(false);
            WaitAll = new ManualResetEvent(false);
        }

        // Метод изменения пикселей
        public static void ChangePixel(object obj)
        {
            var info = (ProccessInfo)obj;

            // Ждём пока не дадут разрешения начать работу
            _instance.SimultaneousLaunch.WaitOne();

            for (int i = info.StartY; i < info.EndY; ++i)
            {
                for (int k = 0; k < _instance._width; ++k)
                {

                    int index = _instance._width * i + k;

                    var clrpixel1 = _instance._firstListColors[index];
                    var clrpixel2 = _instance._secListColors[index];

                    // Анонимный readonly тип, в который вбиваем argb палитру пикселей обоих изображений
                    // и колдуем над ними
                    var newpixel = new
                    {
                        Alpha = clrpixel1.A | clrpixel2.A / 2,
                        Red = clrpixel1.R & clrpixel2.R / 2,
                        Green = clrpixel1.G | clrpixel2.G / 2,
                        Blue = clrpixel1.B >> clrpixel2.B / 3
                    };

                    var newColor = Color.FromArgb(newpixel.Alpha, newpixel.Red, newpixel.Green, newpixel.Blue);

                    // Меняем цвет пикселя
                    lock (_instance.ResultBitmap)
                        _instance.ResultBitmap.SetPixel(k, i, newColor);
                    // поток освобождает оставшуюся часть кванта времени для другого потока
                    Thread.Sleep(0);
                }
            }

            Interlocked.Decrement(ref _instance._threadsRunning);
            // Если мы последний поток, говорим, что все потоки выполнились
            if (_instance._threadsRunning == 0)
                _instance.WaitAll.Set();
        }
    }
}
