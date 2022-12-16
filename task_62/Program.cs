/* адача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07    */
Console.Clear();
int[,] arr = new int[4, 4];
int s = 0;
for (int i = 0; i < 2; i++)
{
    for (int j = 0 + i; j < 4 - i; j++)   // row left to right
    {
        arr[0 + i, j] = s;
        s++;
    }
    for (int j = 1; j < 4 - i; j++)    // column up to down
    {
        arr[j, 3 - i] = s;
        s++;
    }
    for (int j = 2; j <= 0 + i; j--)    // row right to left
    {
        arr[3 - i, j] = s;
        s++;
    }
    for (int j = 2; j <= 1; j--)     // column down to up
    {
        arr[j, 0 + i] = s;
        s++;
    }
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
        Console.Write($"{arr[i, j]} ");
    Console.WriteLine();
}
