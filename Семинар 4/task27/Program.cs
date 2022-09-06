//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

  int SumNums (int number)
  {
    int count = 0;
    int sum = 0;

    for (int i = 0; i <= number; i++){
      count = number - number % 10;
      sum = sum + (number - count);
      number = number / 10;
    }
   return sum;
  }
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(SumNums(num));