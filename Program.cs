using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= quantity; i++)
            {
                int totalPrice = i * 5;
                Console.WriteLine($"Liczba sztuk: {i} łączna cena: {totalPrice}zł");

            }
        }

    }
}
