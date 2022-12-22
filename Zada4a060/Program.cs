Queue<int> que = new Queue<int>(Enumerable.Range(10, 90).OrderBy(x => new Random().NextInt64()));
void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            
            Console.Write($"({i},{j},{k}) {matrix[i, j,k]= que.Dequeue()} \t");
        }
        Console.WriteLine();
    }
}
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[coord[0], coord[1],coord[2]];

Console.WriteLine("\nМатрица имеет вид: ");
InputMatrix(matrix);
