﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
int number;
Console.Write("Введите 3 значное число - ");
int.TryParse(Console.ReadLine()!, out number);
Console.WriteLine($"Вторая цифра данного числа - {number % 100 / 10}");