Console.Clear();
int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
 {
   Console.Write($" Введите элементы массива номер {i} :\t ");
   numbers[i] = Convert.ToInt32(Console.ReadLine());
 }

Console.WriteLine("Вывод массива");
for (int i = 0; i < numbers.Length; i++)

Console.Write($"{numbers[i]} ");