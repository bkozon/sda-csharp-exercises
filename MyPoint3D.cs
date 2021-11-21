using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class MyPoint3D : MyPoint
    {
        public int z;

        public MyPoint3D(int x, int y, int z):
            base(x, y)
        {
            this.z = z;
        }

       
    }
}
