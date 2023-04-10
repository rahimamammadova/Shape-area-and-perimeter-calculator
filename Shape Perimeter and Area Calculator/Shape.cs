using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Perimeter_and_Area_Calculator
{
        internal class Shape
        {
            //field and auto implemented property
            protected double side { get; set; }
            protected double perimeter = 0;
            protected double area = 0;
            public Shape() { }

            //virtual methods to be overriden
            protected virtual void getPerimeter() { }
            protected virtual void getArea() { }
            public void operation()
            {
                Console.WriteLine("Please choose the operation, \n1.Calculate perimeter \n2.Calculate area \n3.Both : ");
                int operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1: getPerimeter(); break;
                    case 2: getArea(); break;
                    case 3: getPerimeter(); getArea(); break;
                }
            }
        }

    }
