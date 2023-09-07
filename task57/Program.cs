/* Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */

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
int[] Convert2DArrayToArray(int[,] array2DForConvert)
{
    int index = 0;
    int rows = array2DForConvert.GetLength(0);
    int cols = array2DForConvert.GetLength(1);
    int[] array = new int[rows * cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[index] = array2DForConvert[i, j];
            index++;
        }
    }

    return array;
}
void PrintFrequencyVocabulary(int[] arrayForCountNumber)
{
    for (int number = 0; number < 10; number++)
    {
        int countNumber = 0;

        for (int i = 0; i < arrayForCountNumber.Length; i++)
        {
            if (number == arrayForCountNumber[i]) countNumber++;
        }

        if (countNumber != 0) Console.WriteLine($"Число {number} встречается {countNumber} раз");
    }
}

int[,] user2DArray = Fill2DArray();
int[] userArray = Convert2DArrayToArray(user2DArray);

Print2DArray(user2DArray);
Console.WriteLine();
PrintFrequencyVocabulary(userArray);