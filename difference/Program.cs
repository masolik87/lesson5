/*Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int size = 7;
double[] arrayRealNumbers = new double[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    arrayRealNumbers[i] = rand.NextDouble() * 100;
    Console.Write(arrayRealNumbers[i] + "\t");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
for (int i = 0; i < size; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}
double difference = maxNumber - minNumber;
Console.WriteLine($"\n разница между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами: {difference}");