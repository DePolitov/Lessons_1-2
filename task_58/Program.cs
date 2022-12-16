/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
 находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18                            */
Console.Clear();
int[,] m1 = new int[3, 3];
int[,] m2 = new int[5, 5];
int[,] m3 = new int[m1.GetLength(0), m2.GetLength(1)];
//m1[0, 0] = 2; m1[0, 1] = 4; m1[1, 0] = 3; m1[1, 1] = 2;     //  значения как в задаче
//m2[0, 0] = 3; m2[0, 1] = 4; m2[1, 0] = 3; m2[1, 1] = 3;    // Для проверки задачи
if (m1.GetLength(0) == m2.GetLength(1))
{
    CreateArray(m1);
    CreateArray(m2);
    for (int i = 0; i < m3.GetLength(0); i++)
    {
        for (int j = 0; j < m3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < m1.GetLength(1); k++)
            {
                sum += m1[i, k] * m2[k, j];
            }
            m3[i, j] = sum;
        }
    }
    PrintArray(m1);
    Console.WriteLine();
    PrintArray(m2);
    Console.WriteLine();
    PrintArray(m3);
}
else
    Console.WriteLine("Матрицы нельзя перемножить!!!");





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