/* Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. */

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
int[] CoordsMinValue(int[,] arrayForFindMinValue)
{
    int minValue = arrayForFindMinValue[0, 0];
    int[] coords = new int[2];

    for (int i = 0; i < arrayForFindMinValue.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForFindMinValue.GetLength(1); j++)
        {
            if (arrayForFindMinValue[i, j] < minValue)
            {
                minValue = arrayForFindMinValue[i, j];
                coords[0] = i;
                coords[1] = j;
            }
        }
    }

    return coords;
}
int[,] DeleteRowAndCol(int[,] arrayForDelete)
{
    int rows = arrayForDelete.GetLength(0);
    int cols = arrayForDelete.GetLength(1);
    int[] coords = CoordsMinValue(arrayForDelete);
    int delRow = coords[0];
    int delCol = coords[1];

    int[] array = new int[(rows - 1) * (cols - 1)];
    int index = 0;

    // заполняем одномерный массив без удалённых значений 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i != delRow && j != delCol)
            {
                array[index] = arrayForDelete[i, j];
                index++;
            }
        }
    }

    // восстанавливаем двумерный массив, но уже без удалённой строки и столбца
    int[,] result = new int[rows - 1, cols - 1];
    index = 0;

    for (int i = 0; i < rows - 1; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            result[i, j] = array[index];
            index++; 
        }
    }

    return result;
}

int[,] userArray = Fill2DArray();
Print2DArray(userArray);
Console.WriteLine();
Print2DArray(DeleteRowAndCol(userArray));