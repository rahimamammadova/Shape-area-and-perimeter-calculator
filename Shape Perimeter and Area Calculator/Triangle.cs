using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Perimeter_and_Area_Calculator
{
    internal class Triangle:Shape
    {
        protected double sideB { get; set; }
        protected double sideC { get; set; }
        private double semiPerimeter = 0;
        public Triangle(double side, double sideB, double sideC)
        {
            this.side = side;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        protected override void getPerimeter()
        {
            perimeter = side + sideB + sideC;
            Console.WriteLine("Perimeter of the triangle is: " + perimeter);
        }
        protected override void getArea()
        {
            semiPerimeter = (side + sideB + sideC) / 2;
            area = Math.Sqrt(semiPerimeter * (semiPerimeter - side) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            Console.WriteLine("Area of the triangle is: " + Math.Round(area, 2));
        }
    }
}
