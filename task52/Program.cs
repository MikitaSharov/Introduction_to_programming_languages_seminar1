/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            Console.Write(arrayForPrint[i, j]);
            if (j != arrayForPrint.GetLength(1) - 1) Console.Write(", ");
            else Console.Write("|");

        }
        Console.WriteLine();
    }
}
double[] AvgEveryColsFrom2DArray(int[,] arrayForAvgEveryCols)
{
    double[] result = new double[arrayForAvgEveryCols.GetLength(1)];

    for (int i = 0; i < arrayForAvgEveryCols.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arrayForAvgEveryCols.GetLength(0); j++)
        {
            sum = sum + arrayForAvgEveryCols[j, i];
        }
        result[i] = sum / arrayForAvgEveryCols.GetLength(1);
    }

    return result;
}
void PrintArray(double[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) System.Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[,] userArray = Fill2DArray();
double[] avgColsFromArray = AvgEveryColsFrom2DArray(userArray);
Print2DArray(userArray);
PrintArray(avgColsFromArray);