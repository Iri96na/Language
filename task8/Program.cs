// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
int current = num % 2;

while (current <= num)
{
    if (current % 2 == 0)
    Console.Write($"{current} ");
    current++;
    
}