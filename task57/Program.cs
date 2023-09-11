/* Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */

Console.Clear();

int[,] user2DArray = Fill2DArray();
int[] userArray = Convert2DArrayToArray(user2DArray);
int[] uniqArray = FillArrayOnlyUniqElements(userArray);

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
int CountUniqElementsInArray(int[] arrayForCountUniqElements)
{
    int uniqueCount = 0;
    bool[] counted = new bool[arrayForCountUniqElements.Length];

    for (int i = 0; i < arrayForCountUniqElements.Length; i++)
    {
        if (!counted[i])
        {
            uniqueCount++;

            for (int j = i + 1; j < arrayForCountUniqElements.Length; j++)
            {
                if (arrayForCountUniqElements[i] == arrayForCountUniqElements[j])
                {
                    counted[j] = true;
                }
            }
        }
    }

    return uniqueCount;
}
int[] FillArrayOnlyUniqElements(int[] array)
{
    int[] uniqArray = new int[CountUniqElementsInArray(userArray)];
    int uniqueCount = 0;  // капец сложный момент с uniqueCount 

    for (int i = 0; i < array.Length; i++)
    {
        bool isUnique = true;

        // Проверяем, является ли элемент уникальным в массиве
        for (int j = 0; j < uniqueCount; j++) // чтобы 0 не переносился в конец массива также используем uniqueCount
        {
            if (array[i] == uniqArray[j])
            {
                isUnique = false;
                break;
            }
        }

        // Если элемент уникальный, добавляем его в новый массив
        if (isUnique)
        {
            uniqArray[uniqueCount] = array[i];
            uniqueCount++;
        }
    }

    return uniqArray;
}
void PrintFrequencyVocabulary(int[] arrayForCountNumber, int[] uniqueArray)
{
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        int element = uniqueArray[i];
        int countElement = 0;
        for (int j = 0; j < arrayForCountNumber.Length; j++)
        {
            if (element == arrayForCountNumber[j]) countElement++;
        }

        Console.WriteLine($"{element} встречается {countElement} раз");
    }
}

Print2DArray(user2DArray);
Console.WriteLine();
PrintArray(userArray);
Console.WriteLine();
PrintArray(uniqArray);
PrintFrequencyVocabulary(userArray, uniqArray);