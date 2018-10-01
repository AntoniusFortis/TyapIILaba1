using System.Drawing;
using ColorList = System.Collections.Generic.List<System.Drawing.Color>;

namespace GloryToSfedu
{
    public readonly struct ProccessInfo
    {
        public readonly int StartY;
        public readonly int EndY;

        public ProccessInfo(int starty, int endy)
        {
            StartY = starty;
            EndY = endy;
        }
    }

    public readonly struct ChangerInfo
    {
        public readonly Bitmap Picture;
        public readonly int ThreadsAmount;
        public readonly ColorList FirstList;
        public readonly ColorList SecondList;

        public ChangerInfo(Bitmap bitmap, int threads, ref ColorList firstList, ref ColorList secondList)
        {
            Picture = bitmap;
            ThreadsAmount = threads;
            FirstList = firstList;
            SecondList = secondList;
        }
    }
}
