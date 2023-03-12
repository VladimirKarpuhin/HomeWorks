// Необходимо вычислить функцию Аккермана с помощью рекурсии.

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}

Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {Ack(M, N)}");