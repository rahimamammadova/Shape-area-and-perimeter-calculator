using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Perimeter_and_Area_Calculator
{
    internal class Square:Shape
    {
        public Square(double side)
        {
            this.side = side;
        }
        protected override void getPerimeter()
        {
            perimeter = side * 4;
            Console.WriteLine("Perimeter of the square is: " + perimeter);
        }
        protected override void getArea()
        {
            area = side * side;
            Console.WriteLine("Area of the square is: " + area);
        }
    }
}
