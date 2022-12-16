/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Clear();
int n;
Console.Write("Введите N - ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine($"n={n} -> {MaxToMin(n, 1)}");

string MaxToMin(int max, int min)
{
    if (max <= min)
        return max.ToString();
    return $"{max} {MaxToMin(max - 1, min)}";
}