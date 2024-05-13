using System;

struct MyComplex
{
    public double Real { get; set; }
    public double Mnim { get; set; }

    public MyComplex(double real, double mnim)
    {
        Real = real;
        Mnim = mnim;
    }

    public override string ToString()
    {
        return $"{Real} + {Mnim}i";
    }

    public static MyComplex operator *(MyComplex a, MyComplex b)
    {
        
        double realPart = (a.Real * b.Real) - (a.Mnim * b.Mnim);
        double mnimPart = (a.Real * b.Mnim) + (a.Mnim * b.Real);
        return new MyComplex(realPart, mnimPart);
    }

    public static MyComplex operator /(MyComplex a, MyComplex b)
    {
       
        double denominator = (b.Real * b.Real) + (b.Mnim * b.Mnim);
        double realPart = ((a.Real * b.Real) + (a.Mnim * b.Mnim)) / denominator;
        double mnimPart = ((a.Mnim * b.Real) - (a.Real * b.Mnim)) / denominator;
        return new MyComplex(realPart, mnimPart);
    }
}


class Program
{
    static void Main()
    {
        MyComplex a = new MyComplex(3, 9);  
        MyComplex b = new MyComplex(4, 5);  
        MyComplex c = new MyComplex(1, 2);  

        MyComplex z = CalculateExpression(a, b, c);

        Console.WriteLine(z);
    }

    static MyComplex CalculateExpression(params MyComplex[] numbers)
    {
        MyComplex result = (numbers[0] * numbers[1]) / numbers[2];
        return result;
    }
}
