using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class SharaFilter : MatrixFilter
    {
        public SharaFilter()
        {
            float[,] shara = new float[,] { { 3,  0,  -3 },
                                              { 10, 0, -10 },
                                              { 3,  0,  -3 } 
            };
            kernel = new float[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    kernel[i, j] = shara[i, j];
        }
    }
}
