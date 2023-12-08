using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPoo.Pillars
{
    public class Current : Bancat
    {
        public override void Credit(decimal value)
        {
            balance += value;
        }
    }
}