// 36

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void SumOddPosition(int[] array)
{
    int a = 0;
    for (int i = 1; i < array.Length; i += 2)
        a += array[i];
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {a}");
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
SumOddPosition(array);