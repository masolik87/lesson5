/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int size = 5;

int[] array = new int[size];
int resultPositive = 0;
for (int i = 0; i < array.Length; i++) // array.Length = size
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + "\t");
    if (array[i] % 2 == 0) resultPositive ++;
}
Console.WriteLine("\n" + $"Positive: {resultPositive}");