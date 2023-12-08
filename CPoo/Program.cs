using Avanade.cs.Design;
using CPoo.Pillars;

/*Cat c = new Cat();
c.Name = "BiBi";
c.Number = 3;
c.Show();

Cub u = new Cub();
u.Name = "Baby";
u.Number = 5;
u.Show();

Dog d = new Dog();
d.Name = "Plínio";
d.Number = 4;
d.Show();

Current t = new Current();
t.Credit(500);
t.DisplayBalance();/* */

Cat c = new Cat();
Dog d = new Dog("Bibi");
Cub u = new Cub("Scoob");

c.Show();
d.Show();
u.Show();
 

 ICalculator i = new Calculadora();
 Console.WriteLine(i.Multiplicar(3, 9));