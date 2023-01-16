// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintFromUntil(int N)
{
    if (N <= 1)
    {
        Console.WriteLine(N);
        return;
    }
    Console.Write($"{N}, ");
    PrintFromUntil(N - 1);
}

PrintFromUntil(12);
