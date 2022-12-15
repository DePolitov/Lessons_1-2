/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.     */
Console.Clear();
int x, y;
Console.Write("Введите количество строк - ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write("Введите количество столбцов - ");
int.TryParse(Console.ReadLine()!, out y);
int[,] array = new int[x, y];
CreateArray(array);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
double s = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        s += array[i, j];
    }
    Console.Write($"{Math.Round(s / array.GetLength(0), 1)}  ");
    s = 0;
}

void CreateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(10);
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }

}