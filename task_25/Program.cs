/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16           */
Console.Clear();
int A, B;
Console.Write("Введите число А - ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write("Введите число B - ");
int.TryParse(Console.ReadLine()!, out B);
int N = 1;
for (int i = 1; i <= B; i++)
    N = N * A;
Console.WriteLine($"{A}, {B} --> {N}");
