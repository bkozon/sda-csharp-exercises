using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję, która będzie wyliczała wartość funkcji silnia dla argumentu podanego przez
            //użytkownika.
            Console.WriteLine("Podaj liczbę:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Podana liczba powinna być >0.");
            }
            else
            {
                Console.WriteLine($"{number}!={Strong(number)}");
            }
        }
       public static int Strong (int number)
        {
            int sum = 1;
            for (int i = 0; i < number; i++)
            {
                sum *= number-i;
                
            }
            return sum;
        }
    }
}
