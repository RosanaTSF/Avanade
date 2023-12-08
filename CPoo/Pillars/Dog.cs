using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPoo.Pillars
{
    public class Dog : Cat
    {
        public Dog(string name) : base(name)

        {
            
        }
            public string Size { get; set; }
            public override void Show()
            {

                Console.WriteLine($"Olá, sou um(a) doguinho(a), meu nome é {Name}, tenho {Number} cores e de porte {Size}. ");       
        }
    }
}