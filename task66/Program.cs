/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int userNumberM = 4;
int userNumberN = 8;
int sum = SumMToN(userNumberM, userNumberN);
Console.WriteLine(sum);

int SumMToN(int numberM, int numberN)
{
    if (numberM == numberN) return numberM;
    else return numberM + SumMToN(numberM + 1, numberN);
}