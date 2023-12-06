using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanade.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string name, string character)
        {
            Name = name;
            Character = character;
        }
        private string _name;
        private int _number;
        public string Name 
        { 
            get => _name.ToUpper();

            set 
            {
                if(value == "")
                {
                    throw new ArgumentException("The name cannot be empty.");
                }

                _name = value;
            }
        }
        public string Character { get; set; }
        public string NameCharacter => $"{Name} {Character}".ToUpper();
        public int Number { 
            get => _number;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Number cannot be less than zero.");
                }

                _number = value;
            } 
        }

        public void Show()
        {
            Console.WriteLine($"Name: {NameCharacter}, I'm a {Number} colored cat. ");
        }
    }
}