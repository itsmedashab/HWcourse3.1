// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

int a;
int b;

Console.Write($"Enter first number: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Enter second number: ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
{
    Console.WriteLine($"First number is bigger than second");
}
else
{
    Console.WriteLine($"Second number is bigger than first");
}