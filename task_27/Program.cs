/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт
 сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12                      */
Console.Clear();
int N, sum, a;
Console.Write("Введите число - ");
int.TryParse(Console.ReadLine()!, out N);
a = N;
sum = 0;
while (a != 0)
{
    sum = sum + a % 10;
    a = a / 10;
}
Console.WriteLine($"{N} -> {sum}");
