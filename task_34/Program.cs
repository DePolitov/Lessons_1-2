/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество
 чётных чисел в массиве.
[345, 897, 568, 234] -> 2              */
Console.Clear();
int[] array = new int[new Random().Next(5, 20)];
CreateArray(array);
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($" -> {count}");

void CreateArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(1000);
    }
}
void PrintArray(int[] arr2)
{
    foreach (int element in arr2)
    {
        Console.Write($"{element}  ");
    }
}
