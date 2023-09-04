/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] Fill2DArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int lines = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[lines, rows];
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + (minValue);
        }
    }

    return array;
}
void Print2DArray(double[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            Console.Write(Math.Round(arrayForPrint[i, j], 1));
            if (j != arrayForPrint.GetLength(1) - 1) Console.Write(", ");
            else Console.Write("|");
            
        }
        Console.WriteLine();
    }
}

double[,] userArray = Fill2DArray();
Print2DArray(userArray);