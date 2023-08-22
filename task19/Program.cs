/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Enter 5 digits number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int numberTurn = 0;

/* if (userNumber > 9999 && userNumber < 100000)
{
    if (userNumber % 10 == userNumber / 10000 && userNumber / 10 % 10 == userNumber / 1000 % 10) Console.WriteLine("true");
    else Console.WriteLine("false");
}
else if (userNumber < -9999 && userNumber > -100000)
{
    if (userNumber % 10 == userNumber / 10000 && userNumber / 10 % 10 == userNumber / 1000 % 10) Console.WriteLine("true");
    else Console.WriteLine("false");
}
else Console.WriteLine("error input"); */

if (userNumber > 9999 && userNumber < 100000)
{
    while (number > 0)
    {
        numberTurn = number % 10 + numberTurn * 10;
        number = number / 10;
    }
    if (userNumber == numberTurn) Console.WriteLine("true");
    else Console.WriteLine("false");
}
else if (userNumber < -9999 && userNumber > -100000) // можно умножить на -1 
{
    while (number < 0)
    {
        numberTurn = number % 10 + numberTurn * 10;
        number = number / 10;
    }
    if (userNumber == numberTurn) Console.WriteLine("true");
    else Console.WriteLine("false");
}
else Console.WriteLine("error input");