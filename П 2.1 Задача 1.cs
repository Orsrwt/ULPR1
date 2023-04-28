using System;

class Program
{
    static void Main()
    {
        float h, r, v;
        double pi = Math.PI;

        Console.Write("Введите радиус основания: ");
        r = float.Parse(Console.ReadLine());

        Console.Write("Введите высоту: ");
        h = float.Parse(Console.ReadLine());

        v = (float)(pi * Math.Pow(r, 2) * h);

        Console.WriteLine("Объем цилиндра равен: " + v);
    }
}
