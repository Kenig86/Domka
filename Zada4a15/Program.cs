Console.Clear();
Console.Write("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7){
Console.WriteLine("Это не день недели.\nВведите день недели: ");
a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 || a == 7)
Console.WriteLine("Этот день выходной.");
else Console.WriteLine("Этот день не выходной.");