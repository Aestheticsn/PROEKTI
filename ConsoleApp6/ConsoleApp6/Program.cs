using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(1);
            double b = Convert.ToDouble(-9);
            double c = Convert.ToDouble(14);
            double D = Convert.ToDouble(Math.Pow(b,2)-(4*a*c));
            double x1 = Convert.ToDouble((-b + Math.Sqrt(D)/2*a));
            double x2 = Convert.ToDouble((-b - Math.Sqrt(D) / 2 * a));
            
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}