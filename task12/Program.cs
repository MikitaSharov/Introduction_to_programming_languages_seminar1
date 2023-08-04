/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому,
то программа выводит остаток от деления.

10:47
34, 5 -> некратно, остаток 4
16, 4 -> кратно */

int number1 = new Random().Next(0, 100);
int number2 = new Random().Next(0, 100);
int n = 0;

if (number2%number1 == 0)
{
    Console.WriteLine($"{number2} кратно {number1}");
}
else
{
    Console.WriteLine($"остаток от деления {number2} на {number1} = {n=number2%number1}");
}