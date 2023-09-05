/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

Console.Write("Сколько чисел вы хотите ввести: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillArray(length);

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}
int CountElementsMoreThanZero(int[] arrayForCount)
{
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (arrayForCount[i] > 0) result++;
    }

    return result;
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

PrintArray(userArray);
Console.WriteLine($"Вы ввели {CountElementsMoreThanZero(userArray)} чисел больше 0");