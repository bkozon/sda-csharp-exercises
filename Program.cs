using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Namaluj trójkąt z gwiazdek o zadanej liczbie linii. Dopełnij pod spodem odwróconym trójkątem tak
            //jak w przykładzie poniżej. Zwróć uwagę, że linia z maksymalną liczba gwiazdek jest tylko jedna.
            //Np.dla 3 linii:
            //*
            //**
            //***
            //**
            //*
            //Rozszerz zadanie tak, aby można było namalować trójkąt dowolonym znakiem zamiast gwiazdką. Odrębna metoda.
            int lines = Convert.ToInt32(Console.ReadLine());
            string sign = Console.ReadLine();
            PrintTriangle(lines, sign);
        }

        public static void PrintTriangle(int lines, string sign)
        {
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
            for (int i = lines-1; i >=1 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }
    }
}
