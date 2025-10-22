using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите радиус:");
            double radius = double.Parse(Console.ReadLine());

            while (radius <= 0)
            {
                Console.WriteLine("Ошибка: радиус должен быть положительным числом!");
                Console.WriteLine("Введите радиус:");
                radius = double.Parse(Console.ReadLine());
            }

            double circleLength = 2 * Math.PI * radius;
            double circleArea = Math.PI * Math.Pow(radius, 2);
            double V = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine("\nРезультаты расчетов:");
            Console.WriteLine($"Радиус: {radius:F2}");
            Console.WriteLine($"Длина окружности: {circleLength:F2}");
            Console.WriteLine($"Площадь круга: {circleArea:F2}");
            Console.WriteLine($"Объем шара: {V:F2}");

            Console.WriteLine("Начало части программы для прямоугольника:");
            Console.WriteLine("Введите длину первой стороны прямоугольника:");
            double firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны прямоугольника:");
            double secondSide = double.Parse(Console.ReadLine());

            double p = 2*(firstSide + secondSide);

            Console.WriteLine($"Периметр прямоугольника: {p:F2}");


        }
    }
}
