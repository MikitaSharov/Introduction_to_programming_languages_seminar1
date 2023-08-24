/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Enter number: ");
Console.WriteLine(SumDigits(Convert.ToInt32(Console.ReadLine())));

int SumDigits(int number)
{
    int sumDigits = 0;
    while(number > 0)
    {
        sumDigits = sumDigits + number%10;
        number/=10;
    }

    return sumDigits;
}