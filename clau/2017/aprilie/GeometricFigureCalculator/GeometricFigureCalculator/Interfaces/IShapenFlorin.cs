using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCalculator.Interfaces
{
    
    public class PointFlorin
    {
        public int X { get; set; }

        public int Y { get; set; }
    }

    public interface IGeometricShapeFlorin
    {
        PointFlorin[] GetAllPoints();
    }

    public class SegmentFlorin : IGeometricShapeFlorin
    {
        public PointFlorin P1 { get; set; }

        public PointFlorin P2 { get; set; }
    }

    public class TriangleFlorin: IGeometricShapeFlorin
    {
        public PointFlorin P1 { get; set; }

        public PointFlorin P2 { get; set; }

        public PointFlorin P3 { get; set; }
    }

    public class SquareFlorin: IGeometricShapeFlorin
    {
        public SquareFlorin(PointFlorin topLeft, int width)
        {
            this.P1 = topLeft;
            // restul se calculeaza in functie de topLeft + width
        }

        public PointFlorin P1 { get; set; }

        public PointFlorin P2 { get; set; }

        public PointFlorin P3 { get; set; }

        public PointFlorin P4 { get; set; }
    }

    public class RectangleFlorin : IGeometricShapeFlorin
    {
        public RectangleFlorin(PointFlorin topLeft, int width, int height)
        {
            this.P1 = topLeft;
            // restul se calculeaza in functie de topLeft + width
        }

        public PointFlorin P1 { get; set; }

        public PointFlorin P2 { get; set; }

        public PointFlorin P3 { get; set; }

        public PointFlorin P4 { get; set; }
    }

    public class TrapezeFlorin : IGeometricShapeFlorin
    {
        public PointFlorin P1 { get; set; }

        public PointFlorin P2 { get; set; }

        public PointFlorin P3 { get; set; }

        public PointFlorin P4 { get; set; }
    }
    
    public static class GeometricCalculator
    {
        public static double GetPerimeter(IGeometricShapeFlorin shape)
        {
            throw new NotImplementedException();
        }

        public static IGeometricShapeFlorin MoveShape(IGeometricShapeFlorin shape, int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }

}
