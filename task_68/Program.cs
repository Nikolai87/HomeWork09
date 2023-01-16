// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumber ("Введите m: ");
int n = InputNumber ("Введите n: ");

int InputNumber (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int FunctionAkkerman (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        n = FunctionAkkerman (m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = FunctionAkkerman (m, n - 1);
        n = FunctionAkkerman (m - 1, n);
    }
    return n;
}

Console.WriteLine ($"A({m}, {n}) = {FunctionAkkerman (m, n)}");
