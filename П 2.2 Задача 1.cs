using System;

namespace MilkDensity
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1030; // плотность молока в кг/м3
            Console.WriteLine("Введите объем молока в литрах: ");
            double x = Convert.ToDouble(Console.ReadLine()); // считываем объем молока с клавиатуры
            double m = x * p / 1000; // вычисляем массу молока в кг
            Console.WriteLine("Масса молока равна " + m + " кг.");
            Console.ReadLine();
        }
    }
}
