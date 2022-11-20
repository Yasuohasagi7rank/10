using System;

namespace _4._124
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Третье число: ");
            c = Convert.ToInt32(Console.ReadLine());

            string d = "";
            try
            {
                double a1 = ((Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * 180) / Math.PI;
                double b2 = ((Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * 180) / Math.PI;
                double c2 = ((Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a))) * 180) / Math.PI;

                if (a == b && a == c)
                {
                    d = "равносторонний";
                }
                if ((a == b && a != c) || (a == c && a != b) || (c == b && c != a))
                {
                    d = "равнобедренный";
                }
                if (a != b && a != c && b != c)
                {
                    d = "разносторонний";
                }

                if (a1 == 90 || b2 == 90 || c2 == 90)
                {
                    Console.Write($"Это {d} прямоугольный треугольник");
                }

                if (a1 > 90 || b2 > 90 || c2 > 90)
                {
                    Console.Write($"Это {d} тупоугольный треугольник");
                }

                if (a1 < 90 && b2 < 90 && c2 < 90)
                {
                    Console.WriteLine($"Это {d} остроугольный треугольник");
                }
            }
            catch
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}
