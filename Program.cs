using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint myPoint1 = new MyPoint(2, 3);
            MyPoint myPoint2 = new MyPoint(5, 2);

            LineSegment lineSegment1 = new LineSegment(myPoint1, myPoint2);
            LineSegment lineSegment2 = new LineSegment(2, 3, 5, 2);

            Console.WriteLine(lineSegment1.Length());

            Console.WriteLine(lineSegment2.Length());

        }
    }
}
