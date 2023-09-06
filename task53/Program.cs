// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/* можно делать разными способами:
 - создать временную переменную;
 - создать временный массив;
 - прибавить к элементам первой строки элементы последней строки,
    присвоить значениям последней строки разницу между первой и последней,
    присвоить значениям первой строки разницу между первой и последней. */

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
int[,] SwapFirstWithLastRowsInArray(int[,] arrayForSwap)
{
    int[] temp = new int[arrayForSwap.GetLength(1)];
    for (int i = 0; i < arrayForSwap.GetLength(1); i++)
    {
        temp[i] = arrayForSwap[0, i];
    }
    for (int i = 0; i < arrayForSwap.GetLength(1); i++)
    {
        arrayForSwap[0, i] = arrayForSwap[arrayForSwap.GetLength(0) - 1, i];
    }
    for (int i = 0; i < arrayForSwap.GetLength(1); i++)
    {
        arrayForSwap[arrayForSwap.GetLength(0) - 1, i] = temp[i];
    }

    return arrayForSwap;
}
int[,] SwapFirstWithLastRowsInArrayWithoutTemp(int[,] arrayForSwap)
{
    int row = arrayForSwap.GetLength(0);

    for (int j = 0; j < arrayForSwap.GetLength(1); j++)
    {
        arrayForSwap[0, j] = arrayForSwap[0, j] + arrayForSwap[row - 1, j];
        arrayForSwap[row - 1, j] = arrayForSwap[0, j] - arrayForSwap[row - 1, j];
        arrayForSwap[0, j] = arrayForSwap[0, j] - arrayForSwap[row - 1, j];
    }

    return arrayForSwap;
}

int[,] userArray = Fill2DArray();
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(SwapFirstWithLastRowsInArray(userArray));
Console.WriteLine();
Print2DArray(SwapFirstWithLastRowsInArrayWithoutTemp(userArray));
