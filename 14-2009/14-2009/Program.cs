using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2009
{
    public class F
    {
        public double X { get; }
        public double Y { get; }

        public F(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
    internal class Program
    {
        public static F CalculateFunction(double x)
        {
            double y = x * x - x * x * x - 1.0 / (4.0 + x);
            return new F(x, y);
        }

        public static void Main()
        {
            double x = 14;
            F result = CalculateFunction(x);
            Console.WriteLine(result);
        }
    }
}
