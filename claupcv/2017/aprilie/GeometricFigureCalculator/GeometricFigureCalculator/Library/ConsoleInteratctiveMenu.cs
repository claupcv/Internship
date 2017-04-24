using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCalculator.Library
{
    public static class ConsoleInteratctiveMenu
    {
        public static void ShowPerimeterToConsole(object  shape, double shapePerimeter)
        {
            Console.WriteLine("Perimeter : {0} = {1}", shape.GetType().Name, shapePerimeter);
        }

        public static void ShowSHapeCoordToConsole(object shape, double shapePerimeter)
        {
            Console.WriteLine("Perimeter : {0} = {1}", shape.GetType().Name, shapePerimeter);
        }
    }
}
