// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int a;
int b;
int c;

Console.Write($"Enter first number: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Enter second number: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Enter third number: ");
int.TryParse(Console.ReadLine()!, out c);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write($"max = {max}\n");