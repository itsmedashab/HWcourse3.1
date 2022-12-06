// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

int a;

Console.Write($"Enter your number: ");
int.TryParse(Console.ReadLine()!, out a);

if (a % 2 == 0)
{
    Console.WriteLine($"Your number is even");
}
else
{
   Console.WriteLine($"Your number is odd"); 
}