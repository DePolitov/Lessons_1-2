/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Clear();
int n, m;
Console.Write("Введите M - ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Введите N - ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine($"M={m}; N={n} -> {Sum(m, n)}");

int Sum(int min, int max)
{
    if (min >= max)
        return min;
    return min = min + Sum(min + 1, max);
}
