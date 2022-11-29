Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0) n = n * -1;
else 
if (n < 99){
Console.WriteLine("Нет третьей цифры\nВведите трехзначное число: ");
n = Convert.ToInt32(Console.ReadLine());
}
while (n > 1000)
    n/=10;
Console.WriteLine(n % 10);