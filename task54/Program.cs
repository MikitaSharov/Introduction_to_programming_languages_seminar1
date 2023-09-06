// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
int[,] SortDecreaseRowsInArray(int[,] arrayForSort)
{
    bool sorted;

    do
    {
        sorted = false;
        for (int i = 0; i < arrayForSort.GetLength(0); i++)
        {
            for (int j = 1; j < arrayForSort.GetLength(1); j++)
            {
                if (arrayForSort[i, j - 1] < arrayForSort[i, j])
                {
                    int temp = arrayForSort[i, j - 1];
                    arrayForSort[i, j - 1] = arrayForSort[i, j];
                    arrayForSort[i, j] = temp;
                    sorted = true;
                }
            }
        }
    } while (sorted);

    return arrayForSort;
}

int[,] userArray = Fill2DArray();
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(SortDecreaseRowsInArray(userArray));