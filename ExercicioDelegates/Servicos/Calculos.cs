using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDelegates.Servicos
{
    class Calculos
    {
        public static double Soma(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplicacao(double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }
    }
}
