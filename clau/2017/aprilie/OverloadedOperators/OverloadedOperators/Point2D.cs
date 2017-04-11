using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperators
{
    class Point2D
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static readonly Point2D PointZero = new Point2D(0, 0);

        public Point2D(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        // override required by "==" operator overloading
        public override int GetHashCode()
        {
            return this.X ^ this.Y;
        }

        // override required by "==" operator overloading
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                // a point cannot be equal to a null object
                return false;
            }

            var otherPoint = obj as Point2D;
            if (otherPoint == null) // conversion failed
            {
                // a point cannot be equal to a non-point object
                return false;
            }

            return (this.X == otherPoint.X) && (this.Y == otherPoint.Y);
        }

        public static Point2D operator +(Point2D p, Displacement2D d)
        {
            if (object.ReferenceEquals(p, null))
            {
                p = Point2D.PointZero;
            }

            if (object.ReferenceEquals(d, null))
            {
                d = Displacement2D.ZeroDisplacement;
            }

            return new Point2D(p.X + d.DX, p.Y + d.DY);
        }

        public static Point2D operator -(Point2D p, Displacement2D d)
        {
            if (object.ReferenceEquals(p, null))
            {
                p = Point2D.PointZero;
            }

            if (object.ReferenceEquals(d, null))
            {
                d = Displacement2D.ZeroDisplacement;
            }

            return new Point2D(p.X - d.DX, p.Y - d.DY);
        }

        public static bool operator ==(Point2D p1, Point2D p2)
        {
            if (object.ReferenceEquals(p1, null) && object.ReferenceEquals(p2, null))
            {
                // both are null => then are equal
                return true;
            }

            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            {
                // one is null, but not both => they are not equal
                return false;
            }

            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }

        public static bool operator !=(Point2D p1, Point2D p2)
        {
            if (object.ReferenceEquals(p1, null) && object.ReferenceEquals(p2, null))
            {
                // both are null => then are not distinct
                return false;
            }

            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
            {
                // one is null, but not both => they are distinct
                return true;
            }

            return (p1.X != p2.X) && (p1.Y != p2.Y);
        }
    }
}
