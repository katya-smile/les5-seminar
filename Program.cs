// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(100,1000);
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]} ");
    if (array[i]%2==0) count++; 
}
Console.WriteLine();
System.Console.WriteLine($"Количество четных элементов: {count}");


// Задача 36: Задайте , заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(1,10);
    Console.Write($"{array[i]} ");
}
int sum=0;
for (int j = 1; j < array.Length; j=j+2)
{
    sum = sum + array[j];
}
Console.WriteLine();
System.Console.WriteLine($"Сумма элементов {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[]array = new double[num];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().NextDouble();
    Console.Write($"{Math.Round(array[i],3)} ");
}
System.Console.WriteLine();
double max =array[0];
double min =array[0];
for (int i = 1; i < array.Length; i++)
{
    if(array[i]< min) min = array[i];
    if(array[i]> max) max = array[i];
}
Console.WriteLine("Разность между максимальным и минимальным = {0}", Math.Round((max - min),3));