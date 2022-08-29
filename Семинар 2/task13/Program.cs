// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число " );
int num = int.Parse(Console.ReadLine());
int num1 = (num/100)%10;

int result = num1;

if (99 > num)
{
Console.WriteLine ($"{num} -> {"третьей цифры нет"}");
}
else
{
    Console.WriteLine($"{num} -> {result}");
}