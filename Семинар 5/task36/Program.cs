// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] GetArray(int size, int minValue, int maxValue)
{
int [] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue);
}
return res;
}
int sumElement(int[] array)
{
int result = 0;
int min = 0;
int max = 0;

if (array[min] > array[max])
result = array[min] - array[max];
else if (array[max] > array[min])
result = array[max] - array[min];
return result;
}


int[] myArray = GetArray(5, 0, 100);
Console.WriteLine(String.Join(",",myArray));
int result = sumElement (myArray);
Console.WriteLine(String.Join("",result));