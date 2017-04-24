using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCalculator.Interfaces
{
    public interface IGeometricShape
    {
        Punct[] GetAllPoints();
    }
}
