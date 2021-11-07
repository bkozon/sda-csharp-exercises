using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 1, 8, 9, 5 };
            BubbleSort(numbers);
        }
        public static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int temp = 0;
                int temp2 = 0;
                if (numbers[i]>numbers[i+1])
                {
                    temp = numbers[i]; 
                    temp2 = numbers[i + 1];
                    numbers[i] = numbers[i + 1];                                              
                    numbers[i + 1] = temp;
                }
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
