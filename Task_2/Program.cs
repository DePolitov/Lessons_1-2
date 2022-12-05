/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
 максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */
int a, b, c;
Console.Write("Введите первое число - ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите второе число - ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write("Введите третье число - ");
int.TryParse(Console.ReadLine()!, out c);
if ((a > b) && (a > c)) { Console.WriteLine($"max = {a}"); }
if ((b > a) && (b > c)) { Console.WriteLine($"max = {b}"); }
if ((c > a) && (c > b)) { Console.WriteLine($"max = {c}"); }
if ((a == b) || (a == c) || (b == c))
{
    Console.WriteLine($"Среди введенных чисел есть равные");
}