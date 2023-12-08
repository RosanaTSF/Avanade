using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPoo.Pillars
{
    public class Cub : Cat
    {
        public Cub()
        {

        }
        public Cub(string name) : base(name)
        {

        }
        public string Collors { get; set; }
    }
}