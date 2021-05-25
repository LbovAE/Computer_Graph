using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class LineHistogram : Filters

    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color source = sourceImage.GetPixel(x, y);
            byte intensity = (byte)(((0.2125 * source.R + 0.7154 * source.G + 0.0721 * source.B) / 3));
            return Color.FromArgb(Clamp(source.R + intensity, 0, 255), Clamp(source.G + intensity, 0, 255), Clamp(source.B + intensity, 0, 255));
        }
        
    }
}
