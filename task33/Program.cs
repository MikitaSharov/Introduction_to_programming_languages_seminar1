/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

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
    Console.WriteLine("]");
}
bool NumberInArray(int[] arrayForSearch)
{
    bool numberInArray = false;
    System.Console.Write("Введи число для поиска в массиве: ");
    int number = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < arrayForSearch.Length; i++)
    {
        if (number == arrayForSearch[i]) numberInArray = true;
    }

    return numberInArray;
}

PrintArray(userArray);
Console.WriteLine(NumberInArray(userArray));
