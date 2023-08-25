/* 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5 */

System.Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(CountDigitsFromNumber(userNumber));

int CountDigitsFromNumber(int number)
{
    int count = 0;
    while(number>0)
    {
        number/=10;
        count++;
    }

    return count;
}