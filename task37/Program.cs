/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

Console.Clear();

int[] userArray = FillArray(6, 0, 11);

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
int[] ArrayProductPairElements(int[] arrayForProduct)
{
    int length = arrayForProduct.Length / 2;
    if (arrayForProduct.Length % 2 == 1) length = arrayForProduct.Length / 2 + 1;
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = arrayForProduct[i] * arrayForProduct[arrayForProduct.Length - 1 - i];
        if (i == arrayForProduct.Length - 1 - i) array[i] = arrayForProduct[arrayForProduct.Length - 1 - i];
    }

    return array;
}

PrintArray(userArray);
PrintArray(ArrayProductPairElements(userArray));