using System;

namespace Simpson
{
    class Program
    {
        static double Y(double p)
        {
            return (Math.Sin(p * p));
        }
        static void Main(string[] args)
        {
            double x, h, s;
            float a, b;
            int n;
            Console.WriteLine("Отрезок интегрирования[a, b] —> (a) =");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Отрезок интегрирования[a, b] —> (b) =");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("На сколько частей нужно разделить отрезок ? n =");
            n = int.Parse(Console.ReadLine());

            h = (b - a) / n;
            s = 0;
            x = a + h;
            while (x < b)
            {
                s += 4 * Y(x);
                x += h;
                s += 2 * Y(x);
                x += h;
            }
            s = h / 3 * (s + Y(a) - Y(b));
            Console.WriteLine("Интеграл = { 0}", s);
            Console.ReadKey();
        }
    }
}
