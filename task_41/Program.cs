/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3                            */
Console.Clear();
int M;
Console.Write("Введите, сколько чисел ввести - ");
int.TryParse(Console.ReadLine()!, out M);
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число {i + 1} - ");
    int.TryParse(Console.ReadLine()!, out array[i]);
}
for (int i = 0; i < M; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine($" -> {CountPositive(array)}");

//void ArrPrintOut(int[] arr1)
{
    //foreach (int element in arr1)


}
int CountPositive(int[] arr)
{
    int countpos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) countpos = countpos + 1;
    }
    return countpos;
}

