
/*Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int size = 5;

int[] array = new int[size];
int resultPositive = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);
    {
        Console.Write(array[i] + "\t");
    }
    if (i % 2 != 0)
        resultPositive = resultPositive + array[i];
}
Console.WriteLine("\t \n" + $"Сумма элементов: {resultPositive}");