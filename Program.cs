using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Mruczuś");
            cat.MakeSound();
            Dog dog = new Dog("Fafik");
            dog.MakeSound();

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (Animal a in animals)
            {
                a.MakeSound();
                if (a is Cat)
                {
                    Console.WriteLine("To jest kotek.");
                }
                else if (a is Dog)
                {
                    Console.WriteLine("To jest piesek.");
                }
                else
                {
                    Console.WriteLine("Jakiś dziwny zwierz.");
                }
            }
        }
    }
}
