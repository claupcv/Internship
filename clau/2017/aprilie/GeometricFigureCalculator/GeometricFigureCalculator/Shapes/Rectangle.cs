using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Interfaces;
using GeometricFigureCalculator.Library;

namespace GeometricFigureCalculator.Shapes
{
    class Rectangle : IGeometricShape
    {
        public Punct P1 { get; set; }

        public Punct P2 { get; set; }

        public Punct P3 { get; set; }

        public Punct P4 { get; set; }

        public Rectangle(Punct topLeft, int width, int heigth)
        {
            this.P2 = new Punct();
            this.P3 = new Punct();
            this.P4 = new Punct();


            this.P1 = topLeft;

            this.P2.X = topLeft.X + width;
            this.P2.Y = topLeft.Y;

            this.P3.X = topLeft.X + width;
            this.P3.Y = topLeft.Y + heigth;

            this.P4.X = topLeft.X;
            this.P4.Y = topLeft.Y + heigth;

        }

        public Punct[] GetAllPoints()
        {
            throw new NotImplementedException();
        }

    }
}
