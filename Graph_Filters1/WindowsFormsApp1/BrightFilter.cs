using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class BrightFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + 40, 0, 255),
                                               Clamp(sourceColor.G + 40, 0, 255),
                                               Clamp(sourceColor.B + 40, 0, 255)
                                               );
            return resultColor;
        }
    }
}
