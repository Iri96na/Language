// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] GetArray(int size, int minValue, int maxValue)
{
int [] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue);
}
return res;
}


/*int[] evenNumber(int[] array)
{
int res = 0;
for (int i = 0; i > array.Length; i++)
{
if (array[i] % 2 == 0)
res++;
}
}
return res;*/

int[] myArray = GetArray(5, 100, 999);
Console.WriteLine(String.Join(" ",myArray));
Console.WriteLine($"{even}");
