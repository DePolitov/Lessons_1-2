/* Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, 
 что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
int row, column, x, y;
Console.Write("Введите количество строк - ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write("Введите количество столбцов - ");
int.TryParse(Console.ReadLine()!, out y);
int[,] array = new int[x, y];
CreateArray(array);
PrintArray(array);
Console.Write("Введите номер строки массива - ");
int.TryParse(Console.ReadLine()!, out row);
Console.Write("Введите номер столбца массива - ");
int.TryParse(Console.ReadLine()!, out column);
if (row > array.GetLength(0) || column > array.GetLength(1))
    Console.Write($"{row}{column} -> такого числа в массиве нет");
else
    Console.Write($"{row}{column} -> {array[row - 1, column - 1]}");

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

