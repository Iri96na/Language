// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

Console.WriteLine("Введите длину массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

int [] array()
{
    int [] array = new int [N];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(A,B);
    }
    return array;
}

Console.WriteLine(String.Join(" ", array()));
