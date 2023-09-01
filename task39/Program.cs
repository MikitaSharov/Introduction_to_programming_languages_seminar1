/*  Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам. */

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
int[] TurnArray(int[] arrayForTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayForTurn.Length / 2; i++)
    {
        temp = arrayForTurn[i];
        arrayForTurn[i] = arrayForTurn[arrayForTurn.Length - 1 - i];
        arrayForTurn[arrayForTurn.Length - 1 - i] = temp;
    }

    return arrayForTurn;
}
Console.ForegroundColor=ConsoleColor.Blue;
PrintArray(userArray);
int[] turnArray = TurnArray(userArray);
Console.ForegroundColor=ConsoleColor.Green;
PrintArray(turnArray);
Console.ForegroundColor=ConsoleColor.White;
