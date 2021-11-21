using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment
    {
        public MyPoint A { get; set; } 
        public MyPoint B { get; set; } 

        public LineSegment(MyPoint a, MyPoint b)
        {
            A = a;
            B = b;
        }

        public LineSegment(int ax, int bx, int ay, int by)
        {
            A.x = ax;
            B.x = bx;
            A.y = ay;
            B.y = by;
        }

        public static double Length(MyPoint A, MyPoint B)
        {
            double dx = A.x - B.x;
            double dy = A.y - B.y;

            double length = Math.Sqrt(dx * dx + dy * dy);

            return length;
        }

        public double Length(int ax, int bx, int ay, int by)
        {
            double dx = ax - bx;
            double dy = ay - by;

            double length = Math.Sqrt(dx * dx + dy * dy);

            return length;
        }


    }
}
