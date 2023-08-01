/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат 
(число умноженное на само себя).


4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(number * number);
