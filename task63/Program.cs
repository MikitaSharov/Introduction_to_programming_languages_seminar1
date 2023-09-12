// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number, int start = 1)
{
    if (start <= number)
    {
        Console.Write(start + " ");
        PrintNumbers(number, start + 1);
    }
}

PrintNumbers(userNumber);