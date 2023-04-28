using System;

class Program
{
    static void Main()
    {
        int number, digit, sum = 0;

        Console.WriteLine("Введите число: ");
        number = int.Parse(Console.ReadLine());

        while (number > 0)
        {
            digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }

            number /= 10;
        }

        Console.WriteLine("Сумма четных цифр: " + sum);
    }
}
