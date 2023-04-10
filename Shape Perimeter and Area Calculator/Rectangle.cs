using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Perimeter_and_Area_Calculator
{
    internal class Rectangle : Shape
    {
        protected double width { get; set; }

        public Rectangle(double side, double width)
        {
            this.side = side;
            this.width = width;
        }
        protected override void getPerimeter()
        {
            perimeter = 2 * (side + width);
            Console.WriteLine("Perimeter of a rectangle is: " + perimeter);
        }
        protected override void getArea()
        {
            area = side * width;
            Console.WriteLine("Area of a rectangle is: " + area);
        }
    }
 }
