/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int number = 0;
int number_check = 0;

while (number_check == 0)
{
    Console.WriteLine("Enter a three-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number >= 100 && number < 1000)
    {
        Console.WriteLine($"{number / 10 % 10}");
        number_check = 1;
    }
    else Console.WriteLine("Error!");
}