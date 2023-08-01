/*
# Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

11:05
Console.WriteLine(result);
*/

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.Write("правда");
}
else
{
    Console.Write("ложь");
}
