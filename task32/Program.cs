﻿/* Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Clear();

System.Console.Write("Введи размер массива: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, min, max);

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] ChangeSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }

    return array;
}

PrintArray(userArray);
System.Console.WriteLine();
PrintArray(ChangeSignArray(userArray));