using System;

namespace lab1
{
    class Program
    {
        static double a, b, c;
        static void Main(string[] args)
        {
            a = 1;
            b = -5;
            c = 6;
            Console.WriteLine("Hello World!");
            double[] x = Calculate();
            Console.WriteLine("x1 = {0}, x2 = {1}", x[0], x[1]);
        }

        static double[] Calculate() {
            double discrRoot = Math.Sqrt(b*b - 4*a*c);
            return new double[] {(-b-discrRoot)/(2*a), (-b+discrRoot)/(2*a)};
        }
    
    }
}
