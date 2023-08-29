/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

Console.Clear();

int[] userArray = FillArray(123, 0, 200);

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

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
void PrintQtyElementsFromArray(int[] arrayForCount)
{
    int count = 0;
    for (int i = 0; i < arrayForCount.Length; i++)
    {
        if (arrayForCount[i] > 9 && arrayForCount[i] < 100) count++;
    }
    Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
}

PrintArray(userArray);
PrintQtyElementsFromArray(userArray);