// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

System.Console.WriteLine("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray());

int[] FillArray()
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
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