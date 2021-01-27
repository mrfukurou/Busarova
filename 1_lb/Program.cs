using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону треугольника a= ");
            float a = float.Parse(Console.ReadLine());
            double r = a / (2 * Math.Sqrt(3));
            Console.WriteLine("Радиус вписанной окружности r=" + r);

        }
    }
}
