/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Enter A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exponent(numberA, numberB));

if (numberB < 0) System.Console.WriteLine("EXPONENT > 0");

int Exponent(int numberA, int numberB)
{
    int numberC = 1;
    for (int i = 1; i < numberB + 1; i++)
    {
        numberC = numberC * numberA;
    }
    return numberC;
}