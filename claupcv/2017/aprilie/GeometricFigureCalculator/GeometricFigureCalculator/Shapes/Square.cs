using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Interfaces;
using GeometricFigureCalculator.Library;

namespace GeometricFigureCalculator.Shapes
{
    public class Square : IGeometricShape
    {
        Punct P1 { get; set; }

        Punct P2 { get; set; }

        Punct P3 { get; set; }

        Punct P4 { get; set; }

        public Square(Punct topLeft, int width)
        {
            this.P1 = new Punct() { X = topLeft.X,         Y = topLeft.Y };
            this.P2 = new Punct() { X = topLeft.X + width, Y = topLeft.Y};
            this.P3 = new Punct() { X = topLeft.X + width, Y = topLeft.Y + width };
            this.P4 = new Punct() { X = topLeft.X,         Y = topLeft.Y + width };
            
        }

        public Punct[] GetAllPoints()
        {

            return new[]  {this.P1, this.P2, this.P3, this.P4  };
        }

    }
}
