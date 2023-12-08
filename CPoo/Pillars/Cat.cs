using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPoo.Pillars
{
    public class Cat
    {
        public Cat()
        {
            
        }
        public Cat(string name)
        {
            Name = name;
        }
       public string Name { get; set; } 
       public int Number { get; set; }
       public virtual void Show()
       {
            Console.WriteLine($"Me chamo {Name} e tenho {Number} cores.");
       }


    }
}