Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Большее число: {a}");
    Console.WriteLine($"Меньшее число: {b}");
}
else
{
    Console.WriteLine($"Большее число: {b}");
    Console.WriteLine($"Меньшее число: {a}");
}