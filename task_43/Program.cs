/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)                              */
Console.Clear();
double k1, b1, k2, b2;
Console.Write("Введите b1 - ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write("Введите k1 - ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write("Введите b2 - ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write("Введите k2 - ");
double.TryParse(Console.ReadLine()!, out k2);
Console.Write($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ");
Console.WriteLine($"({(b2 - b1) / (k1 - k2)}; {k1 * (b2 - b1) / (k1 - k2) + b1})");