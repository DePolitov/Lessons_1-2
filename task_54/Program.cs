/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2                                     */
Console.Clear();
int x, y;
Console.Write("Введите количество строк - ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write("Введите количество столбцов - ");
int.TryParse(Console.ReadLine()!, out y);
int[,] array = new int[x, y];
CreateArray(array);
PrintArray(array);
Console.WriteLine("Массив с упорядоченными элементами по убыванию: ");
for (int k = 0; k < array.GetLength(0); k++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int s = array[k, i];
        int j = i - 1;
        while (j >= 0 && array[k, j] < s)
        {
            array[k, j + 1] = array[k, j];
            array[k, j] = s;
            j--;
        }
    }
}
PrintArray(array);

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

void FromMaxToMin(int[] arr)  //Упорядочивание элементов в одномерном массиве [1  4   5   6]
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] > max)
            {
                max = arr[j];
                arr[i] = max;
            }
        }
    }
}