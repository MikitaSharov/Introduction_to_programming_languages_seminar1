/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120 */

int numberA = new Random().Next(1,10);
System.Console.WriteLine($"произведение чисел от 1 до {numberA} = {ProductDititsFromNumber(numberA)}");

int ProductDititsFromNumber(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product*=i;
    }

    return product;
}