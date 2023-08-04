/* Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.

11:13
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1==number2*number2 || number2==number1*number1)
{
    Console.WriteLine("Одно число является квадратом другого числа");
}
else
{
    Console.WriteLine("Одно число не является квадратом другого числа");
}