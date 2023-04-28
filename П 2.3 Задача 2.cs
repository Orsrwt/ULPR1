using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год (формат: yyyy):");
        int year = int.Parse(Console.ReadLine());

        for (int month = 1; month <= 12; month++)
        {
            DateTime date = new DateTime(year, month, 1);
            int daysUntilThursday = ((int)DayOfWeek.Thursday - (int)date.DayOfWeek + 7) % 7;
            DateTime Thursday = date.AddDays(daysUntilThursday);

            Console.WriteLine($"В {date.ToString("MMMM")} {year} года санитарный день приходится на {Thursday.Day} число");
        }
    }
}
