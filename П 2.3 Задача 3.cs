using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите максимальное значение для загадываемого числа: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество попыток: ");
        int k = int.Parse(Console.ReadLine());

        int secretNumber = new Random().Next(1, n + 1);

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"Попытка {i}: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Вы угадали!");
                return;
            }
            else
            {
                Console.WriteLine($"Загаданное число {(guess < secretNumber ? "больше" : "меньше")}.");
            }
        }

        Console.WriteLine($"Попытки закончились. Было загадано число {secretNumber}.");
    }
}
