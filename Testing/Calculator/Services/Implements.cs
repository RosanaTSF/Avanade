using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class Implements
    {
        public int Somar (int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public bool Par(int num)
        {
            return num % 2 == 0;
        }
    }
}