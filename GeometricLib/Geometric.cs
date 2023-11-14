using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricLib
{
    public static class Geometric
    {
        //площадь круга 
        public static double AreaOfTheCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("радиус не может быть меньше или равен нулю");
            }
            return Math.PI * Math.Pow(radius, 2);
        }

        //площадь треугольника (если треугольник не равносторонний, сторона sideC всегда должны бать самой большой)
        public static double AreaOfTheTriangle(double sideA, double sideB, double sideC)
        {
            // расчет полупериметра
            double P = (sideA + sideB + sideC) / 2;

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("сторона не может быть меньше или равен нулю");


            if (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2)) //если треугольник прямоугольный
                return (sideA * sideB) / 2;

            else
                return Math.Sqrt(P * (P - sideA) * (P - sideB) * (P - sideC));
        }
    }
}
