using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine(" Введите коэффициенты квадратного уравнения:");
            if (
                double.TryParse(Console.ReadLine(), out x) &&
                double.TryParse(Console.ReadLine(), out y) &&
                double.TryParse(Console.ReadLine(), out z) 
            ) {
                Console.WriteLine("D = [{0}]", string.Join(", ", Calculate(x, y, z)));
            } else {
                Console.WriteLine("Ошибка ввода данных!");
            }
        }

<<<<<<< HEAD
        static double[] Calculate(double x1, double x2, double x3) {
=======
        static double[] Calculate(double x, double y, double z) {
>>>>>>> param
            double discrRoot = Math.Sqrt(y*y - 4*x*z);
            return new double[] {(-y-discrRoot)/(2*x), (-y+discrRoot)/(2*x)};
        }
    
    }
}
