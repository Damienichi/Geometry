using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Triangle: IFigure
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }
        public bool Rectangular { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0) throw new ArgumentException("Стороны должны быть больше 0");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Rectangular = IsRectangular(sideA, sideB, sideC);
        }


        public double GetArea()
        {
            var p = (SideA + SideB + SideC) / 2d; //Полупериметр
            return Math.Sqrt((p * (p - SideA) * (p - SideB) * (p - SideC)));
        }

        private bool IsRectangular(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB)
            {
                if (sideA > sideC)
                {
                    return (Math.Pow(sideA, 2) == (Math.Pow(sideC, 2) + Math.Pow(sideB, 2))) ? true : false;
                }
            }

            if (sideB > sideC)
            {
                return (Math.Pow(sideB, 2) == (Math.Pow(sideC, 2) + Math.Pow(sideA, 2))) ? true : false;
            }

            return (Math.Pow(sideC, 2) == (Math.Pow(sideA, 2) + Math.Pow(sideB, 2))) ? true : false;
        }
    }
}
