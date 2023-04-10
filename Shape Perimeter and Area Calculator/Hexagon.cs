using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Perimeter_and_Area_Calculator
{
    internal class Hexagon:Shape
    {
        public Hexagon(double side)
        {
            this.side = side;
        }
        protected override void getPerimeter()
        {
            perimeter = 6 * side;
            Console.WriteLine("Perimeter of the Hexagon is: " + perimeter);
        }
        protected override void getArea()
        {
            area = ((3 * Math.Sqrt(3)) * (side * side)) / 2;
            Console.WriteLine("Area of the Hexagon is: " + Math.Round(area, 2));
        }
    }
}
