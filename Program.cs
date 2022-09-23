Console.Clear();

Console.Write("Введите координату Х точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2)));
