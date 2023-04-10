using Shape_Perimeter_and_Area_Calculator;

Console.WriteLine("Please choose the shape,\n1.Rectangle \n2.Triangle \n3.Square \n4.Hexagon :");
int shape = int.Parse(Console.ReadLine());

switch (shape)
{
    case 1:
        Console.Write("Please enter the length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Please enter the width: ");
        double width = double.Parse(Console.ReadLine());

        Shape rectangle = new Rectangle(length, width);
        rectangle.operation();
        break;
    case 2:
        Console.Write("Please enter the first side of triangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second side of triangle: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third side of triangle: ");
        double c = double.Parse(Console.ReadLine());

        Shape triangle = new Triangle(a, b, c);
        triangle.operation();
        break;
    case 3:
        Console.Write("Please enter the side of square: ");
        double side = double.Parse(Console.ReadLine());

        Shape square = new Square(side);
        square.operation();
        break;
    case 4:
        Console.Write("Please enter the side of hexagon: ");
        double sideH = double.Parse(Console.ReadLine());

        Shape hexagon = new Hexagon(sideH);
        hexagon.operation();
        break;
}