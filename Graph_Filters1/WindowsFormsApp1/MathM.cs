using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    class MathM : Filters
    {
        protected int[,] mask;

        protected MathM() { }
        public MathM(int[,] mask)
        {
            this.mask = mask;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
