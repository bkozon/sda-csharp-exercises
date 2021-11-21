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

            MyPoint3D myPoint3D = new MyPoint3D(2, 3, 4);
            MyPoint3D myPoint3D2 = new MyPoint3D(5, 6, 7);
            LineSegment lineSegment3 = new LineSegment(myPoint3D, myPoint3D2);
            Console.WriteLine(lineSegment3.Length3D());

        }
    }
}
