// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());

int result = (num / 10) % 10;

Console.WriteLine ($"{num} -> {result}");
