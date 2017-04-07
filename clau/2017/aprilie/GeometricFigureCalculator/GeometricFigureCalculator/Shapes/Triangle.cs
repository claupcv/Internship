using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Interfaces;
using GeometricFigureCalculator.Library;

namespace GeometricFigureCalculator.Shapes
{
    class Triunghi : IGeometricShape
    {
        Punct P1 { get; set; }

        Punct P2 { get; set; }

        Punct P3 { get; set; }

        public Triunghi(Punct point1, Punct point2, Punct point3)
        {

            this.P1 = point1;

            this.P2 = point2;

            this.P3 = point3;

        }

        public Punct[] GetAllPoints()
        {
            Punct[] points = new Punct[3];

            points[0] = this.P1;
            points[1] = this.P2;
            points[2] = this.P3;

            return points;
        }
    }
}
