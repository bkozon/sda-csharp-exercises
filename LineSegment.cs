using System;

namespace sda_csharp_exercises
{
    class LineSegment
    {
        public MyPoint A { get; set; } 
        public MyPoint B { get; set; } 
        public MyPoint3D C { get; set; }
        public MyPoint3D D { get; set; }


        public LineSegment(MyPoint a, MyPoint b)
        {
            A = a;
            B = b;
        }

        public LineSegment(MyPoint3D c, MyPoint3D d)
        {
            C = c;
            D = d;
        }

        public LineSegment(int ax, int bx, int ay, int by)
        {
            A = new MyPoint(ax, ay);
            B = new MyPoint(bx, by);
        }

       
        public double Length()
        {
            double dx = A.x - B.x;
            double dy = A.y - B.y;

            double length = Math.Sqrt(Math.Pow(dx,2) + Math.Pow(dy,2));

            return length;
        }

        public double Length3D()
        {
            double dx = C.x - D.x;
            double dy = C.y - D.y;
            double dz = C.z - D.z;

            double length = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)+ Math.Pow(dz, 2));

            return length;
        }

    }
}
