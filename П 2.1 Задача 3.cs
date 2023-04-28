using System;

class Program
{
    static void Main()
    {
        int n, prod = 1;

        Console.Write("Введите целое число: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            int digit = n % 10;
            prod *= digit;
            n /= 10;
        }

        Console.WriteLine("Произведение цифр числа равно: " + prod);
    }
}
