using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Shapes;
using GeometricFigureCalculator.Library;
using GeometricFigureCalculator.Interfaces;

namespace GeometricFigureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Punct punct = new Punct();

            Punct punct2 = new Punct();
            punct2.X = 10;

            Square square = new Square(punct, 10);
            double shapePerimeter = GeometricShapeCalculator.GetPerimeter(square);
            ConsoleInteratctiveMenu.ShowPerimeterToConsole(square, shapePerimeter);

            Segment segment = new Segment(punct, punct2);
            shapePerimeter = GeometricShapeCalculator.GetPerimeter(segment);
            
            Math.Pow(Math.Sqrt(10 - 1), 2);
            Console.WriteLine("Movement  : {0} : (({1}),({2})) ", segment.GetType(), segment.P1.X + "," + segment.P1.Y, segment.P2.X + "," + segment.P2.Y);
            GeometricShapeCalculator.ShapeMove(segment, 10, 5);
            Console.WriteLine("by: (10,5) : (({0}),({1})) ", segment.P1.X + "," + segment.P1.Y, segment.P2.X + "," + segment.P2.Y);





            Console.ReadKey();
        }
    }
}
