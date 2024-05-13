using System;

class Rhombus
{
    protected double side;

    public Rhombus(double s)
    {
        Side = s;
    }

    public virtual double CalculateArea()
    {
        return Side * Side * Math.Sqrt(3) / 2.0;
    }

    public double Side
    {
        get { return side; }
        set { side = value; }
    }
}

class Square : Rhombus
{
    private double side;

    public Square(double s) : base(s)
    {
        Side = s;
    }

    public override double CalculateArea()
    {
        return Side * Side;
    }

    public new double Side
    {
        get { return side; }
        set { side = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        double sideSquare, sideRhombus;

        sideSquare = double.Parse(Console.ReadLine());
        sideRhombus = double.Parse(Console.ReadLine());
        Square square = new Square(sideSquare);
        Rhombus rhombus = new Rhombus(sideRhombus);
        Console.WriteLine("sk " + square.CalculateArea());
        Console.WriteLine("sr " + rhombus.CalculateArea());

        if (square.CalculateArea() > rhombus.CalculateArea())
        {
            Console.WriteLine(">");
        }
        else if (square.CalculateArea() < rhombus.CalculateArea())
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("=");
        }
    }
}
