// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

int index = 1;
int a;

Console.Write($"Enter your number: ");
int.TryParse(Console.ReadLine()!, out a);

while (index < a)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index} ");
    }
    index++;
}

Console.Write($"\n");