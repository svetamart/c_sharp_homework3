Console.WriteLine("Введите число N");

bool checkTheNumber = int.TryParse(Console.ReadLine(), out int n);
if(!checkTheNumber)
{
    Console.WriteLine("Ошибка, число введено неверно");
    return;
}

PrintCubes (GetCubes(n));
int[] GetCubes(int n)
{
    int i = 1;
    int[] cubes = new int[n];
    while (i <= n)
    {
        cubes[i - 1] = (int) Math.Pow (i, 3);                                        
        i++;
    }
    return cubes;
}

void PrintCubes(int[] cubes) 
{
    int i = 0;
    int size = cubes.Length;
    while (i < size)
    {
        Console.Write($" {cubes[i]}");
        i++;
    }
}

