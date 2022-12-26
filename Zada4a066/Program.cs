int rec(int a, int b)
{
    if (a > b)
        return 0;
    return rec(a + 1, b) + a;
}
Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов в промежутке ({m},{n}) равна {rec(m, n)}");