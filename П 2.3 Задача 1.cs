using System;

class Program
{
    static void Main()
    {
        int a, b, c;
        int[] daysInMonthNonLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int[] daysInMonthLeapYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        bool isLeapYear = false;

        Console.WriteLine("Введите год (формат: yyyy):");
        c = int.Parse(Console.ReadLine());
        if ((c % 4 == 0 && c % 100 != 0) || c % 400 == 0)
        {
            Console.WriteLine(c + " - високосный год");
            isLeapYear = true;
        }
        else
        {
            Console.WriteLine(c + " - не високосный год");
        }

        int[] d = isLeapYear ? daysInMonthLeapYear : daysInMonthNonLeapYear;

        Console.WriteLine("Введите месяц (числом):");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите день:");
        a = int.Parse(Console.ReadLine());

        if (b < 1 || b > 12 || a < 1 || a > d[b - 1])
        {
            Console.WriteLine("Неверная дата");
        }
        else
        {
            // номер дня с начала года
            int dayOfYear = a + d.Take(b - 1).Sum();
            Console.WriteLine("Номер дня с начала года: " + dayOfYear);
            // количество дней до конца года
            int daysLeft = isLeapYear ? 366 - dayOfYear : 365 - dayOfYear;
            Console.WriteLine("Дней до конца года: " + daysLeft);
        }

        Console.ReadLine();
    }
}
