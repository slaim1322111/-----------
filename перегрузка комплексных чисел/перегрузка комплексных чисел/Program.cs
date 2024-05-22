using System;

namespace bin_operators
{
    public class Binary
    {
        public int Value { get; private set; }

        public Binary(int value)
        {
            Value = value;
        }

       
        public static Complex operator +(Binary b, Complex c)
        {
          
            return new Complex(b.Value + c.Real, c.Imaginary);
        }
    }

    public class Complex
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var a = new Complex(3, 2);
           var bin = new Binary(5);
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"bin: {bin.Value}");
            Complex result = bin + a;
            Console.WriteLine($"bin + a: {result}");
        }
    }
}
