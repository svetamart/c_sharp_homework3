Console.WriteLine("Введите координату x первой точки: ");
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int x1);

Console.WriteLine("Введите координату y первой точки: ");
bool isNumberY1 = int.TryParse(Console.ReadLine(), out int y1);

Console.WriteLine("Введите координату z первой точки: ");
bool isNumberZ1 = int.TryParse(Console.ReadLine(), out int z1);

Console.WriteLine("Введите координату x второй точки: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int x2);

Console.WriteLine("Введите координату y второй точки: ");
bool isNumberY2 = int.TryParse(Console.ReadLine(), out int y2);

Console.WriteLine("Введите координату z второй точки: ");
bool isNumberZ2 = int.TryParse(Console.ReadLine(), out int z2);

if(!isNumberX1 || !isNumberY1 || !isNumberX2 || !isNumberY2 || !isNumberZ1 || !isNumberZ2) 
{
    Console.WriteLine("Одно или несколько чисел введены неверно");
    return;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
}

double result = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {result}");