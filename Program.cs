using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Person person = new Person("Joanna", "Ostrowska", 1992);
            //person.WhoAmI();
            //Person person2 = new Employee("Adam", "Nowak", 1986, 6000);
            //person2.WhoAmI();
            //Employee employee = new Employee("Jan", "Kowalski", 1982, 5000);
            //employee.WhoAmI();

            List<Person> people = new List<Person>();
            people.Add(new Person("Jan", "Kowalski", 1982));
            people.Add(new Employee("Adam", "Nowak", 1986, 6000));

            foreach (var p in people)
            {
                Console.WriteLine(p);
            }

        }
    }
}