/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53     */
int xa, ya, za, xb, yb, zb;
Console.Write("Введите координату xa - ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write("Введите координату ya - ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write("Введите координату za - ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write("Введите координату xb - ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write("Введите координату yb - ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write("Введите координату zb - ");
int.TryParse(Console.ReadLine()!, out zb);
Console.WriteLine($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}), ->{Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb))}");