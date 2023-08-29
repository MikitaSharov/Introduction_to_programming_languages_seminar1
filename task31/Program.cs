/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20. */

Console.Clear();

int[] userArray = FillArray(12, -9, 10);

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    return array;
}
void PrintArray(int[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) System.Console.Write(", ");
    }
    Console.WriteLine("]");
}
void PrintSumPositiveAndSumNegativeElements(int[] arrayForSum)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arrayForSum.Length; i++)
    {
        if (arrayForSum[i] > 0) sumPositive += arrayForSum[i];
        else sumNegative += arrayForSum[i];
    }
    Console.WriteLine($"sum positive = {sumPositive}, sum negative = {sumNegative}");
}

PrintArray(userArray);
PrintSumPositiveAndSumNegativeElements(userArray);