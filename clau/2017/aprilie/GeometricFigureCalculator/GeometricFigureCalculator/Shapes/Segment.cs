using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Interfaces;
using GeometricFigureCalculator.Library;

namespace GeometricFigureCalculator.Shapes
{
    public class Segment : IGeometricShape
    {
        public Punct P1 { get; set; }

        public Punct P2 { get; set; }
    }
}
