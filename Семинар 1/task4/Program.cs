// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int d = int.Parse(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (d > max) max = d;

Console.Write("max = ");
Console.WriteLine(max);
