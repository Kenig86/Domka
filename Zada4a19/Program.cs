Console.Clear();
Console.WriteLine("Введите пять чисел: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 10000 == a % 10 && (a / 1000) % 10 == (a / 10) % 10) 
 Console.WriteLine("Палиндром"); 
 else 
 Console.WriteLine("Не палиндром");