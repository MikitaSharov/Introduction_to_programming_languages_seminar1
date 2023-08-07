/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 1000) number = number / 10;
if (number < 1000 && number >= 100) Console.WriteLine($"{number % 10}");
else Console.WriteLine("Don't have third digit!");