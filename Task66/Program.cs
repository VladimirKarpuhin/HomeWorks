// Необходимо найти сумму натуральных элементов в промежутке от M до N.

int Sum(int a, int b)
{
    if (a == 0) 
        return (b * (b + 1)) / 2;            // Если a равно нулю
    else if (b == 0) 
        return (a * (a + 1)) / 2;            // Если b равно нулю
    else if (a == b) 
        return a;                            // Если a=b
    else if (a < b) 
        return b + Sum(a, b - 1);            // Если a<b
    else 
        return b + Sum(a, b + 1);            // Если a>b
}

Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {Sum(M, N)}");