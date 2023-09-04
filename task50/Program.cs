/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */

int[,] Fill2DArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int lines = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[lines, rows];
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
void PrintElementFrom2DArray(int[,] array)
{
    Console.WriteLine("Введите позицию элемента:");
    Console.Write("Строка: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец: ");
    int row = Convert.ToInt32(Console.ReadLine());

    if (line < array.GetLength(0) && row < array.GetLength(1)) Console.WriteLine(array[line, row]);
    else Console.WriteLine("нет такого элемента");
}


int[,] userArray = Fill2DArray();
Print2DArray(userArray);
PrintElementFrom2DArray(userArray);