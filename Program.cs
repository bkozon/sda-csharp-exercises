using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint A = new MyPoint(2, 3);
            MyPoint B = new MyPoint(4, 5);
            Console.WriteLine(LineSegment.Length(A, B));
            
        }
    }
}
