// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int a = 0;
int b = 0;
int count = 0;
    while (num > a)
    {
        b = num % 10;
        a = a * 10 + b;
        num = num / 10;
        count++;
    }
    if (a == num)
    {
        Console.WriteLine("Да");
    }
    else
    {
     num = num * 10 + b;
  if (a == num)
    Console.WriteLine("Да");
  else
    Console.WriteLine("Нет");
    }
   