using System;

namespace CheckInequality
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine()); // ввод числа a с клавиатуры
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine()); // ввод числа b с клавиатуры
            Console.WriteLine("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine()); // ввод числа c с клавиатуры

            bool isLess = a < b && b < c; // проверяем выполнение неравенства

            if (isLess)
            {
                Console.WriteLine("Неравенство a < b < c выполняется.");
            }
            else
            {
                Console.WriteLine("Неравенство a < b < c не выполняется.");
            }

            Console.ReadLine();
        }
    }
}
