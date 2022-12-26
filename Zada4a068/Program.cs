int rec(int m, int n)
{
    if (m == 0 )
        return n+1;
    else 
    if (m>0&&n==0)
        return rec(m-1,1);
    else
    if(m>0&&n>0)
        return rec(m-1,rec(m,n-1));
    else
        return 0;
}
Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана двух чисел ({m},{n}) равна {rec(m, n)}");