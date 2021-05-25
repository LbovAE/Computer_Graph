using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Median : Filters
    {
        protected int radius;

        public Median(int radius)
        {
            this.radius = radius;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = radius;
            int radiusY = radius;

            List<int> RR = new List<int>();
            List<int> GG = new List<int>();
            List<int> BB = new List<int>();

            for (int l = -radiusY; l <= radiusY; ++l)
                for (int k = -radiusX; k <= radiusX; ++k)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    RR.Add(sourceImage.GetPixel(idX, idY).R);
                    GG.Add(sourceImage.GetPixel(idX, idY).G);
                    BB.Add(sourceImage.GetPixel(idX, idY).B);
                }
            RR.Sort();
            GG.Sort();
            BB.Sort();

            return Color.FromArgb(RR[RR.Count / 2], GG[GG.Count / 2], BB[BB.Count / 2]);
        }
    }
}
