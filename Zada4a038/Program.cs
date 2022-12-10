// 38

double MaxMin(double[] array)
{
    double a = 0, Max = array[0], Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
            Max =  array[i];
            else
            Min = array[i];

    }
    a = Max - Min;
 
    return a;
    
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Ведите {i + 1} элемент массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

Console.WriteLine($"Разниуа между max и min элементами массива: {MaxMin(array)}");