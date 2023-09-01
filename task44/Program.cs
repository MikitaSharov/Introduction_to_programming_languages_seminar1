/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

int[] FillFibArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    Console.Write("Введите первый элемент массива: ");
    array[0] = Convert.ToInt32(Console.ReadLine());
    array[1] = array[0] + 1;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

int[] fibArray = FillFibArray();
PrintArray(fibArray);