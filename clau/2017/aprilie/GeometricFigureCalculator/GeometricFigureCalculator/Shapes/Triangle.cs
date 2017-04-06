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

    }
}
