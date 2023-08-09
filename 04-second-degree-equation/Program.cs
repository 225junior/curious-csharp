Console.WriteLine("====== Programme de calcul d'équation de second degré =====\n\n");

Console.WriteLine("L'équation est sous la forme : aX^2 + bX + c");

Console.Write("Saisissez le nombre a : ");
int a, b, c;
double d;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("====== Mauvaise saisie de a (nombre entier)! =====\n");
    Console.WriteLine("Resaisissez le nombre a : ");
}

Console.Write("Saisissez le nombre b : ");
while (!int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("====== Mauvaise saisie de b (nombre entier)! =====\n");
    Console.WriteLine("Resaisissez le nombre b : ");
}

Console.Write("Saisissez le nombre c : ");
while (!int.TryParse(Console.ReadLine(), out c))
{
    Console.WriteLine("====== Mauvaise saisie de c (nombre entier)! =====\n");
    Console.WriteLine("Resaisissez le nombre c : ");
}

Console.WriteLine("===== Calcul du discriminat ==== \n");
d = Math.Pow(b, 2) - 4 * a * c;

Console.WriteLine($"discriminat : d = {d}");


