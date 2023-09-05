/* Напишите программу,
которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования. */

int[] CreateRandomArray()
{
    Console.Write("Длина массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    Console.Write("мин значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("макс значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    return array;
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
int[] CopyArray(int[] arrayForCopy)
{
    int[] array = new int[arrayForCopy.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arrayForCopy[i];
    }

    return array;
}

PrintArray(CopyArray(CreateRandomArray()));