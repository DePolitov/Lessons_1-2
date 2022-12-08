/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76     */
Console.Clear();
double[] array = new double[new Random().Next(3, 10)];
CreateArray(array);
PrintArray(array);
Console.WriteLine($" -> {MaxInArray(array) - MinInArray(array)}");

void CreateArray(double[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = new Random().Next(100);
    }
}
void PrintArray(double[] arr2)
{
    foreach (int element in arr2)
    {
        Console.Write($"{element}  ");
    }
}
double MaxInArray(double[] arr3)
{
    double _max = arr3[0];
    for (int i = 1; i < arr3.Length; i++)
    {
        if (arr3[i] > _max) _max = arr3[i];

    }
    return _max;
}

double MinInArray(double[] arr4)
{
    double _min = arr4[0];
    for (int i = 1; i < arr4.Length; i++)
    {
        if (arr4[i] < _min) _min = arr4[i];

    }
    return _min;
}