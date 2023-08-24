/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = FillArray(8);
Console.WriteLine("[" + String.Join(", ", array) + "]");

int[] FillArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter {i} element array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}
