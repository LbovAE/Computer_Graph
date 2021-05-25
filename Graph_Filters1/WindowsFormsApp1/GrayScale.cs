using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class GrayScale : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(double)(sourceColor.R * 0.299) + (int)(double)(sourceColor.G * 0.587) + (int)(double)(sourceColor.B * 0.114);
            Color resultColor = Color.FromArgb(intensity,
                                               intensity,
                                               intensity
                                               );
            return resultColor;
        }

    }
}
