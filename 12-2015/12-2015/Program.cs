using System;

public abstract class Shape<T> 
{
    public T Side { get; set; }

    public Shape(T side)
    {
        Side = side;
    }

    public abstract double CalculateArea();
}

public class Rhombus : Shape<(double Side, double Height)>
{
    public Rhombus(double side, double height) : base((side, height)) { }

    public override double CalculateArea()
    {
        return Side.Side * Side.Height;
    }
}

public class Square : Shape<double>
{
    public Square(double side) : base(side) { }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("ромба1 ");
        double rhombusSide = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите высоту ромба2 ");
        double rhombusHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину стороны квадрата: ");
        double squareSide = Convert.ToDouble(Console.ReadLine());

        Rhombus rhombus = new Rhombus(rhombusSide, rhombusHeight);
        Square square = new Square(squareSide);

        double rhombusArea = rhombus.CalculateArea();
        double squareArea = square.CalculateArea();

        Console.WriteLine($"Площадь ромба: {rhombusArea}");
        Console.WriteLine($"Площадь квадрата: {squareArea}");

        if (rhombusArea > squareArea)
        {
            Console.WriteLine("Больше.");
        }
        else if (rhombusArea < squareArea)
        {
            Console.WriteLine("Меньше.");
        }
        else
        {
            Console.WriteLine("равны");
        }
    }
}
