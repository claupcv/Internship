using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Interfaces;
using GeometricFigureCalculator.Library;

namespace GeometricFigureCalculator.Shapes
{
    class Trapeze
    {
        Punct P1 { get; set; }
        Punct P2 { get; set; }
        Punct P3 { get; set; }
        Punct P4 { get; set; }

        public Trapeze(Punct topLeft, Punct bottomLeft, int topBarWidth, int bottomBarWidth)
        {
            this.P2 = new Punct();
            this.P3 = new Punct();
            this.P4 = new Punct();

            this.P1 = topLeft;

            this.P2.X = topLeft.X + topBarWidth;
            this.P2.Y = topLeft.Y;

            this.P3.X = bottomLeft.X + bottomBarWidth;
            this.P3.Y = bottomLeft.Y;

            this.P4 = bottomLeft;

        }
    }
}
