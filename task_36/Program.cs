/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0   */
Console.Clear();
int[] array = new int[new Random().Next(3, 10)];
CreateArray(array);
PrintArray(array);
int count = 0;
for (int i = 1; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        count = count + array[i];
    }
}
Console.WriteLine($" -> {count}");

void CreateArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(100);
    }
}
void PrintArray(int[] arr2)
{
    foreach (int element in arr2)
    {
        Console.Write($"{element}  ");
    }
}

