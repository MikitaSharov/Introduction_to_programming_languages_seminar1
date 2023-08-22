Console.WriteLine("Ввдедите xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввдедите xB: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввдедите yA: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввдедите yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

double resultAB = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB));
Console.WriteLine(Math.Round(resultAB, 2));