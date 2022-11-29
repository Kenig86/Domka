Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n >= 100) n/= 10;
Console.WriteLine(n % 10);