// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введите число: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int start, int finish)
{
    if (start <= finish)
    {
        Console.Write(start + " ");
        PrintNumbers(start + 1, finish);
    }
}

PrintNumbers(userNumberM, userNumberN);