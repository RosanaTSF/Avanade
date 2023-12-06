using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Avanade.Models
{
    public class Course
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetNumberOfStudentsEnrolled()
        {
            int amount = Students.Count;
            return amount;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student); 
        }

        public void ListStudents()  
        {
            Console.WriteLine($"New students at the school of Witchcraft and Wizardry {Name}:");

            for(int count = 0; count < Students.Count; count++)
            {
                //string text = "Nº " + count + " - " + Students[count].NameCharacter;
                string text = $"Nº {count + 1} - {Students[count].NameCharacter}";
                 Console.WriteLine(text);
            }

        }

    }
}