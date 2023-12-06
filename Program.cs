
using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;
using Avanade.Models;

Person p1 = new Person(name: "Penélope", character: "Frajola");
p1.Number = 2;
p1.Show();

Person p2 = new Person(name: "Catatau", character: "Meowth");
p2.Number = 2;
p2.Show();

Course wicca = new Course();
wicca.Name = "Hogwarts";
wicca.Students = new List<Person>();

wicca.AddStudent(p1);
wicca.AddStudent(p2);
wicca.ListStudents();















