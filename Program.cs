using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Potęga:");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wynik:");
            Power(power, number);
        }

        public static void Power(int power, int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Liczba powinna być większa niż 0.");
            }
            else
            {
                for (int i = 0; i < power - 1; i++)
                {
                    number = number * number;


                }
                Console.WriteLine(number);
            }
        }
    }
}
