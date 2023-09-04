/* Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введеди координату b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеди координату k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеди координату b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеди координату k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
float x = CalculationX(b1, b2, k1, k2);
float y = CalculationY(x, b1, k1);

if (CheckCoords(b1, b2, k1, k2))
{
    Console.WriteLine($"({x}; {y})");
}

float CalculationX(int b1, int b2, int k1, int k2)
{
    float x = (float)(b2 - b1) / (k1 - k2);

    return x;
}
float CalculationY(float x, int b1, int k1)
{
    float y = (float)(k1 * x + b1);

    return y;
}
bool CheckCoords(int b1, int b2, int k1, int k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("прямые параллельны");
            return false;
        }
    }

    return true;
}
