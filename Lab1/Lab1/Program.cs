using System;
using System.Numerics;
using static System.Math;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            solveQuadraticSEquation();

        }

        static void solveQuadraticSEquation()
        {
            Console.WriteLine("Введите коэффиценты квадратного уравнения:");
            var A = getNumber("A");
            var B = getNumber("B");
            var C = getNumber("C");

            var discriminant = B * B - 4 * A * C;

            if (discriminant > 0)
            {
                var root1 = (-B + Sqrt(discriminant)) / (2 * A);
                var root2 = (-B - Sqrt(discriminant)) / (2 * A);
                Console.WriteLine("D>0; Два разных корня;");
                Console.WriteLine("x1 = {0};\nx2 = {1};",root1,root2);
            }
            else if (discriminant == 0)
            {
                var root= -B / (2 * A);
                Console.WriteLine("D=0; Два одинаковых корня;");
                Console.WriteLine("x1 = x2 = {0};",root);
            }
            else
            {
                var imaginaryPart = Sqrt(-discriminant);
                var realPart = -B / (2 * A);
                Console.WriteLine("D<0; Комплексные корни;");
                Console.WriteLine("x1={0}+{1}i",realPart,imaginaryPart);
                Console.WriteLine("x1={0}-{1}i",realPart,imaginaryPart);
            }
        }
        static double getNumber(string message)
        {
            do
            {
                Console.WriteLine($"Введите коэффициент {message}: ");
                var success = double.TryParse(Console.ReadLine(), out var num);
                if (success)
                {
                    return num;
                }
                Console.WriteLine("Ошибка. Введите действительное число.\n");
            } while (true);
        }
    }
}