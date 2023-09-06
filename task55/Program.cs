/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

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
int[,] SwapColsWithRowsInArray(int[,] arrayForSwap)
{
    for (int i = 0; i < arrayForSwap.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForSwap.GetLength(1); j++)
        {
            if (j > i)
            {
                int temp = arrayForSwap[i, j];
                arrayForSwap[i, j] = arrayForSwap[j, i];
                arrayForSwap[j, i] = temp;
            }
        }
    }

    return arrayForSwap;
}

int[,] userArray = Fill2DArray();

if (userArray.GetLength(0) == userArray.GetLength(1))
{
    Print2DArray(userArray);
    Console.WriteLine();
    Print2DArray(SwapColsWithRowsInArray(userArray));
}
else Console.WriteLine("массив должен быть квадратным");
