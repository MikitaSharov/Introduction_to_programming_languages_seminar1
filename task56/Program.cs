/* Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

Console.Clear();

int[,] Fill2DArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return array;
}
void Print2DArray(int[,] arrayForPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayForPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(arrayForPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[] SumRowsIn2DArray(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }

    return sumRows;
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
void PrintSmallestElement(int[] array)
{
    int smallestSum = array[0];
    int rowFrom2DArray = 0; // Номер элементна будет соответствовать строке в двумерном массиве.

    for (int i = 1; i < array.Length; i++)
    {
        if (smallestSum > array[i])
        {
            smallestSum = array[i];
            rowFrom2DArray = i;
        }
    }

    Console.WriteLine($"Наименьшая сумма элементов будет в {rowFrom2DArray} строке и она равна {smallestSum}");
}

int[,] userArray = Fill2DArray();
int[] sumRowsArray = SumRowsIn2DArray(userArray);

Print2DArray(userArray);
Console.WriteLine();
PrintArray(sumRowsArray);
Console.WriteLine();
PrintSmallestElement(sumRowsArray);


