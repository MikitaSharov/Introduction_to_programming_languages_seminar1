/* Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y). */

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt16(Console.ReadLine());

if (quarter == 1) Console.WriteLine("x и y положительные");
else if (quarter == 2) Console.WriteLine("x отрицательное и y положительное");
else if (quarter == 3) Console.WriteLine("x и y отрицательное");
else if (quarter == 4) Console.WriteLine("x положительнок и y отрицательное");
else Console.WriteLine("нет такой четверти");