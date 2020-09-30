
using System;
using System.Collections.Generic;

namespace cccsharp
{
    delegate void ShowMessage(String message);
    delegate double Sum(double lhs, double rhs);
    class Program
    {
        private const int V = 1;

        static void ShowMessage(String message)
        {
            Console.WriteLine(message);
        }
        static void TakeInt(int value)
        {
            Console.WriteLine(value);
        }
        static double Sum(double lhs, double rhs) => lhs + rhs;
        static double Mult(double a, double b, Func<double, double, double> sum)
        {
            return a * sum(a, b);
        }
        //event Action<double,double>

        static void Main(string[] args)
        {
            Console.WriteLine(Mult(1.3, 2.6, Sum));
            Console.WriteLine(Mult(1.3, 2.6, (a, b) => a + b));
            Console.WriteLine(Mult(1.3, 2.6, (a, b) =>
            {
                for (int i = (int)a - 1; i != 1; --i)
                {
                    
                    a *= i;
                }
                return a - (b * b * b * b * b);
            }));
        }
    }
}
