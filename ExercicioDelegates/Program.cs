using ExercicioDelegates.Servicos;
using System;

namespace ExercicioDelegates
{
    class Program
    {
        delegate double BinaryCalculatorOperation(double num1, double num2);
        static void Main(string[] args)
        {
            double a = 5;
            double b = 5;

            BinaryCalculatorOperation op = Calculos.Soma;

            double result = op(a, b);

            Console.WriteLine(result);
        }
    }
}
