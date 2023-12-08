using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPoo.Pillars
{
    public abstract class Bancat
    {
        protected decimal balance;
        public abstract void Credit(decimal value);

        public void DisplayBalance()
        {
            Console.WriteLine("O seu saldo é: " + balance);
        }

    }
}