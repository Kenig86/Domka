Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ((a > b) && (a > c))
max = a;
else if ((b > a) && (b > c))
max = b;
else if ((c > a) && (c > b))
max = c;

Console.WriteLine($"Максимальное число: {max}");