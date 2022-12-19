Console.Clear();
Console.WriteLine("Введите размер массива через пробел: ");
int [] coord = Console.ReadLine().Split(" ").Select(s =>int.Parse(s)).ToArray();
double [,] matrix = new double[coord[0],coord[1]];
void InputMatrix(double [,] matrix){
    for(int i=0; i<matrix.GetLength(0); i++){
        for(int j=0; j<matrix.GetLength(1);j++){
            matrix[i,j]=Math.Round( new Random().NextDouble()*10,2);
Console.Write($"{matrix [i,j]}\t");
    }
Console.WriteLine();
}
}
InputMatrix(matrix);