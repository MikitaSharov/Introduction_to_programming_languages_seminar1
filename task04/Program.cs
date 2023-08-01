/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > number1 && number2 > number3)
{
    max = number2;
}
else if (number3 > number1 && number3 > number2)
{
    max = number3;
}
else
{
    Console.Write(max + " максимальное число");
}
Console.Write(max + " максимальное число");