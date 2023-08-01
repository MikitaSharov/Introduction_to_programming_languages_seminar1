/*
03. # Напишите программу, которая будет выдавать название дня недели по заданному номеру.

11:38
3 -> Среда
5 -> Пятница

11:38
*/

Console.WriteLine("Введите день недели от 1 до 7: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 1)
{
    Console.Write("понедельник");
}
else if (numberDay == 2)
{
    Console.Write("вторник");
}
else if (numberDay == 3)
{
    Console.Write("среда");
}
else if (numberDay == 4)
{
    Console.Write("четверг");
}
else if (numberDay == 5)
{
    Console.Write("пятница");
}
else if (numberDay == 6)
{
    Console.Write("суббота");
}
else if (numberDay == 7)
{
    Console.Write("воскресенье");
}
else
{
    Console.Write("число от 1 до 7 НАДО");
}