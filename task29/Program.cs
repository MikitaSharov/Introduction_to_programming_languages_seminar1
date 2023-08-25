/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int min = new Random().Next(1,10);
int[] array = FillArray(new Random().Next(1,10), min, min + new Random().Next(1,20)); //эксперименты... 
Console.WriteLine("[" + String.Join(", ", array) + "]");

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    return array;
}
