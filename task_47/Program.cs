/* рок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Clear();
int m, n;
Console.Write("Введите m - ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Введите n - ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 20 - 10;
        Console.Write("{0,4}", Math.Round(array[i, j], 1));
        Console.Write(" ");
    }
    Console.WriteLine();

}