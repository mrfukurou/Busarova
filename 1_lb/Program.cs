using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону треугольника a= ");
            float A = float.Parse(Console.ReadLine());
            double R = A / (2 * Math.Sqrt(3));
            Console.WriteLine("Радиус вписанной окружности r=" + R);

        }
    }
}
