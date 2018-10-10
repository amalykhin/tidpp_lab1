using System;

namespace lab1
{
    class Program
    {
        static double a, b, c;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quadratic equation coefficients:");
            if (
                double.TryParse(Console.ReadLine(), out a) &&
                double.TryParse(Console.ReadLine(), out b) &&
                double.TryParse(Console.ReadLine(), out c) 
            ) {
                Console.WriteLine("x = [{0}]", string.Join(", ", Calculate()));
            } else {
                Console.WriteLine("Input parse failed.");
            }
        }

        static double[] Calculate() {
            double discrRoot = Math.Sqrt(b*b - 4*a*c);
            return new double[] {(-b-discrRoot)/(2*a), (-b+discrRoot)/(2*a)};
        }
    
    }
}
