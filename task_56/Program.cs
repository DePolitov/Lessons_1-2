/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7                         
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка */
Console.Clear();
int x, y;
Console.Write("Введите количество строк - ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write("Введите количество столбцов - ");
int.TryParse(Console.ReadLine()!, out y);
int[,] array = new int[x, y];
CreateArray(array);
PrintArray(array);
int[] row = new int[array.GetLength(1)];  // массив из первой строки матрицы
for (int i = 0; i < row.Length; i++)           // заполнение массива 
    row[i] = array[0, i];
int imin = 0;
int min = 0;
for (int i = 0; i < array.GetLength(1); i++)
    min += row[i];
for (int i = 1; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j];
    if (sum < min)
    {
        imin = i;
        min = sum;
    }
}
Console.WriteLine($"Номер строки с минимальной суммой элементов - {imin + 1}");

void CreateArray(int[,] arr)   //Создание массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(10);
}

void PrintArray(int[,] arr)       //Печать массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }

}

