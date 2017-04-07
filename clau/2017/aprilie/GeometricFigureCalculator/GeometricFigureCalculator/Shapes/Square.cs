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
            this.P2 = new Punct();
            this.P3 = new Punct();
            this.P4 = new Punct();

            this.P1 = topLeft;
                        
            this.P2.X = topLeft.X + width;
            this.P2.Y = topLeft.Y;

            this.P3.X = topLeft.X + width;
            this.P3.Y = topLeft.Y + width;

            this.P4.X = topLeft.X;
            this.P4.Y = topLeft.Y + width;
        }

        public Punct[] GetAllPoints()
        {
            Punct[] points = new Punct[4];
            points[0] = this.P1;
            points[1] = this.P2;
            points[2] = this.P3;
            points[3] = this.P4;

            return points;
        }

    }
}
