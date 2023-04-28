using System;

class Program
{
    static void Main()
    {
        int num, sum = 0;

        do
        {
            num = int.Parse(Console.ReadLine());
            sum += num;
        } while (num != 0);

        Console.WriteLine("Сумма: " + sum);
    }
}
