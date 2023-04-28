using System;

class Program
{
    static void Main()
    {
        double r1, r2, area;

        Console.Write("Введите радиус кольца: ");
        r1 = double.Parse(Console.ReadLine());

        Console.Write("Введите радиус отверстия: ");
        r2 = double.Parse(Console.ReadLine());

        if (r1 <= 0 || r2 <= 0)
        {
            Console.WriteLine("Радиусы должны быть положительными.");
        }
        else if (r2 >= r1)
        {
            Console.WriteLine("Радиус отверстия должен быть меньше радиуса кольца.");
        }
        else
        {
            area = Math.PI * (Math.Pow(r1, 2) - Math.Pow(r2, 2));
            Console.WriteLine(area);
        }
    }
}
