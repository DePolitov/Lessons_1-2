﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
int a, b;
Console.Write("Введите первое число - ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число - ");
int.TryParse(Console.ReadLine()!, out b);
if (a > b) { Console.WriteLine($"max = {a}"); }
if (b > a) { Console.WriteLine($"max = {b}"); }
if (a == b) { Console.WriteLine($"Числа равны"); }