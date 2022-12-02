Console.Clear();
Console.WriteLine("Введите координату точки А: ");
double xa = Convert.ToDouble(Console.ReadLine());
double xb = Convert.ToDouble(Console.ReadLine());
double xc = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки В: ");
double ya = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double yc = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xa - ya, 2) + Math.Pow(xb - yb, 2) + Math.Pow(xc - yc, 2));
Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");