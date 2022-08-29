// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели ");
int day = int.Parse(Console.ReadLine());
if (5 < day && day < 8) 
{
     Console.WriteLine($"{day} -> Да");
} 
    else if (0 < day && day < 6)
     {
        Console.WriteLine($"{day} -> Нет");
    }
else 
{
   Console.WriteLine("Такого дня недели нет");
}