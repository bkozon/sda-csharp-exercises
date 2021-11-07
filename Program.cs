using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję tworzącą ciąg arytmetyczny o podanych: długości, pierwszym elemencie, różnicy ciągu.
            Console.WriteLine("Długość ciągu arytmetycznego:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pierwszy element ciągu");
            int firstElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rożnica między elementami ciągu:");
            int difference = Convert.ToInt32(Console.ReadLine());
            ArithmeticSequence(length, firstElement, difference);
           

        }
        public static void ArithmeticSequence(int length, int firstElement, int difference)
        {
            int sum = firstElement;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(sum); 
                sum += difference;
            }

        }
    }
}
