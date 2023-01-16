// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumElements(int M, int N)
{
    if (M>=N)
    {
        return M;
    }
    return M + SumElements(M+1, N);
}

Console.WriteLine(SumElements(5, 15));
