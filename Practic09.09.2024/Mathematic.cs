using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic09._09._2024
{
    class Mathematic
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mult(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            if (y == 0) 
                return 0;

            return x / y;
        }
    }
}
