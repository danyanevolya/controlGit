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
            
            Console.WriteLine("\nРезультаты расчетов:");
            Console.WriteLine($"Радиус: {radius:F2}");
            Console.WriteLine($"Длина окружности: {circleLength:F2}");
            
        }
    }
}
