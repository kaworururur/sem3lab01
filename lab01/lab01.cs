//using System;

//namespace LAB1_
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"byte: min = {byte.MinValue}, max = {byte.MaxValue}");
//            Console.WriteLine($"sbyte: min = {sbyte.MinValue}, max = {sbyte.MaxValue}");
//            Console.WriteLine($"short: min = {short.MinValue}, max = {short.MaxValue}");
//            Console.WriteLine($"ushort: min = {ushort.MinValue}, max = {ushort.MaxValue}");
//            Console.WriteLine($"int: min = {int.MinValue}, max = {int.MaxValue}");
//            Console.WriteLine($"uint: min = {uint.MinValue}, max = {uint.MaxValue}");
//            Console.WriteLine($"long: min = {long.MinValue}, max = {long.MaxValue}");
//            Console.WriteLine($"ulong: min = {ulong.MinValue}, max = {ulong.MaxValue}");

//            Console.WriteLine($"float: min = {float.MinValue}, max = {float.MaxValue}");
//            Console.WriteLine($"double: min = {double.MinValue}, max = {double.MaxValue}");
//            Console.WriteLine($"decimal: min = {decimal.MinValue}, max = {decimal.MaxValue}");

//            Console.WriteLine($"bool: true / false");

//            Console.WriteLine($"char: min = {char.MinValue}, max = {char.MaxValue}");

//            Console.WriteLine($"DateTime: min = {DateTime.MinValue}, max = {DateTime.MaxValue}");
//            Console.WriteLine($"TimeSpan: min = {TimeSpan.MinValue}, max = {TimeSpan.MaxValue}");

//            Console.WriteLine($"Nullable<T>: null");

//            Console.ReadKey();
//        }
//    }
//}


//using System;
//using LAB1_2;


//namespace LAB1_2
//{
//     class Rectangle
//    {
//        private double side1;
//        private double side2;

//        public Rectangle(double sideA, double sideB)
//        {
//            side1 = sideA;
//            side2 = sideB;
//        }

//        private double CalculateArea()
//        {
//            return side1 * side2;
//        }

//        private double CalculatePerimeter()
//        {
//            return 2*(side1 + side2);
//        }
//        public double Area
//        {
//            get { return CalculateArea(); }
//        }

//        public double Perimeter
//        {
//            get { return CalculatePerimeter(); }
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите длину первой стороны прямоугольника:");
//        double sideA = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите длину второй стороны прямоугольника:");
//        double sideB = double.Parse(Console.ReadLine());

//        Rectangle rectangle = new Rectangle(sideA, sideB);

//        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
//        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");

//        Console.ReadKey();
//    }
//}

using System;
using System.Runtime.CompilerServices;

class Point
{
    private int x;
    private int y;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Figure
{
    private Point[] points;
    private string name;

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[4];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        points[3] = p4;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double LengthSide(Point A, Point B)
    {
        int dx = A.X - B.X;
        int dy = A.Y - B.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }

        if (points.Length > 2) 
        {
            perimeter += LengthSide(points[points.Length - 1], points[0]);
        }

        Console.WriteLine($"Название фигуры: {name}");
        Console.WriteLine($"Периметр: {perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 5);
        Point p3 = new Point(5, 5);
        Point p4 = new Point(5, 0);

        Figure rectangle = new Figure(p1, p2, p3, p4);
        rectangle.Name = "Прямоугольник";
        rectangle.PerimeterCalculator();
    }
}