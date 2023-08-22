/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Enter 5 digits number: ");
int number = Convert.ToInt16(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10) Console.WriteLine("true");
    else Console.WriteLine("false");
}
else Console.WriteLine("error input");