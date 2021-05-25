using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class SepFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)(double)(sourceColor.R * 0.299) + (int)(double)(sourceColor.G * 0.587) + (int)(double)(sourceColor.B * 0.114);
            Color resultColor = Color.FromArgb(
                                                Clamp(intensity + 2*15, 0, 255),
                                                Clamp((int)(intensity + 0.5*15), 0, 255),
                                                Clamp(intensity - 1*15, 0, 255)
                                                );
            return resultColor;
        }
    }
}
