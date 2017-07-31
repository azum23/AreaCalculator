using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Calculator
    {
        public double GetArea(double side1, double side2, double side3)
        {
            if (side1 == 0 || side2 == 0 || side3 == 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть равна 0!");
            }

            double p = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return area;
        }
    }
}
