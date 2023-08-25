// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int numberA = new Random().Next(1, 10);
System.Console.WriteLine($"сумма чисел от 1 до {numberA} = {SumDititsFromNumber(numberA)}");

int SumDititsFromNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}

