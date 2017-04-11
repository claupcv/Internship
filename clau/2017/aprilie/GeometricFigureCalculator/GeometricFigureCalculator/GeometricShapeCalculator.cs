using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCalculator.Interfaces;
using GeometricFigureCalculator.Shapes;
using System.Collections;

namespace GeometricFigureCalculator
{
    public static class GeometricShapeCalculator
    {
        public static double GetPerimeter(IGeometricShape shape)
        {
            Punct[] points = shape.GetAllPoints();
            double totalPerimeter=0;

            if (points.Length > 2)
            {
                for (int i = 0; i < points.Length; i++)
                {
                    if (i == points.Length - 1)
                    {
                        totalPerimeter = totalPerimeter + DistanceBetween2Points(points[0], points[i]);
                    }
                    else
                    {
                        totalPerimeter = totalPerimeter + DistanceBetween2Points(points[i], points[i+1]); 
                    }
                }
            }
            else if (points.Length == 2)
            {
                totalPerimeter = totalPerimeter + DistanceBetween2Points(points[0], points[1]);
            }
            return totalPerimeter;
        }

        public static double DistanceBetween2Points(Punct firstPoint, Punct seccondPoint)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(firstPoint.X - seccondPoint.X, 2) + Math.Pow(firstPoint.Y - seccondPoint.Y, 2)));
        }

        public static IGeometricShape ShapeMove(IGeometricShape shape, int dx, int dy)
        {
            
            Punct[] points = shape.GetAllPoints();
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = points[i].X + dx;
                points[i].Y = points[i].Y + dy;
            }



            return shape;

        }

        public static void TestIfArrayImplementsICollectionFlorin()
        {
            var points = new [] 
            { 
                new Punct { X = 100, Y = 200 },
                new Punct { X = 250, Y = 120 },
            };

            var genericCollection = points as ICollection<Punct>;
            if(genericCollection != null)
            {
                Console.WriteLine("Array implements ICollection<T>");
            }

            var nonGenericCollection = points as ICollection;
            if(nonGenericCollection != null)
            {
                Console.WriteLine("Array implements ICollection");
            }
        }


    }
}
