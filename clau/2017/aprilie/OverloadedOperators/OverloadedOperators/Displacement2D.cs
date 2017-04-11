using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperators
{
    class Displacement2D
    {
        public int DX { get; set; }

        public int DY { get; set; }

        public static readonly Displacement2D ZeroDisplacement = new Displacement2D(0, 0);

        public Displacement2D(int dx = 0, int dy = 0)
        {
            this.DX = dx;
            this.DY = dy;
        }

    }
}
