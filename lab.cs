using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1 (в: 9)  -------------------------------------------

            Console.Write("Введите радиус основания r: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Введите высоту h: ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Введите образующую l: ");
            double l = double.Parse(Console.ReadLine());

            double V = (1.0 / 3.0) * Math.PI * r * r * h;

            double S = Math.PI * r * l;

            Console.WriteLine($"Объём конуса V = {V:F3}");
            Console.WriteLine($"Площадь боковой поверхности S = {S:F3}");

            // задание 2 (в: 9) -------------------------------------------
            
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            if (a != b)
            {
                int min = Math.Min(a, b);
                a = min;
                b = min;
            }
            else
            {
                a = 0;
                b = 0;
            }

            Console.WriteLine($"a = {a}, b = {b}"); 

            // задание 3 (в: 9) -------------------------------------------
            int sum = 0;

            while (sum <= 100)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Сумма положительных чисел превысила 100. Итог: {sum}");
        }
    }
}