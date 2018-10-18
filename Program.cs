using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter quadratic equation coefficients:");
            if (
                double.TryParse(Console.ReadLine(), out a) &&
                double.TryParse(Console.ReadLine(), out b) &&
                double.TryParse(Console.ReadLine(), out c) 
            ) {
                Console.WriteLine("x = [{0}]", string.Join(", ", Calculate(a, b, c)));
            } else {
                Console.WriteLine("Input parse failed.");
            }
        }

<<<<<<< HEAD
        static double[] Calculate(double a1, double a2, double a3) {
=======
        static double[] Calculate(double a, double b, double c) {
>>>>>>> param
            double discrRoot = Math.Sqrt(b*b - 4*a*c);
            return new double[] {(-b-discrRoot)/(2*a), (-b+discrRoot)/(2*a)};
        }
    
    }
}
