using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    class Closing : MathM
    {
        public Closing()
        {
            this.mask = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        }

        public Closing(int[,] mask)
        {
            this.mask = mask;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = sourceImage;
            Filters filter = new Dilation();
            resultImage = filter.processImage(resultImage, worker);
            filter = new Erosion();
            resultImage = filter.processImage(resultImage, worker);
            return resultImage;
        }
    }
}
