using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Circle: IFigure
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Радиус должен быть больше 0", nameof(radius));

            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
