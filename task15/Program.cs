/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int DayCheck = 0;

while (DayCheck == 0)
{
    Console.WriteLine("Enter day of week (1-7): ");
    int DayOfWeek = Convert.ToInt32(Console.ReadLine());
    
    if (DayOfWeek == 6 || DayOfWeek == 7)
    {
        Console.WriteLine("Today is a day off =D");
        DayCheck++;
    }
    else if (DayOfWeek <6 && DayOfWeek >=1)
    {
        Console.WriteLine("Today is a working day :(");
        DayCheck++;
    }
    else Console.WriteLine("Incorrect input!");
}
