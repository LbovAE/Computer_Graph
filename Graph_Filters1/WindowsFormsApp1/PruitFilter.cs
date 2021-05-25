using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PruitFilter : MatrixFilter
    {
        public PruitFilter()
        {
            kernel = new float[3, 3] { {-1, -1, -1},
                                        { 0, 0, 0 },
                                        { 1, 1, 1 } 
            };
        }
    }
}
