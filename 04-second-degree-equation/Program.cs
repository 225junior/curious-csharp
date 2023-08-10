Console.WriteLine("====== Programme de calcul d'équation de second degré =====\n\n");

Console.WriteLine("L'équation est sous la forme : aX^2 + bX + c = 0");

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

if (d < 0)
{
    Console.WriteLine($"Aucune solution possible pour l'équation  (E): {a}X^2 + {b}X + {c} = 0");
}
else if (d == 0)
{
    Console.WriteLine($"Une solution possible pour l'équation  (E): {a}X^2 + {b}X + {c} = 0");

    float s0 = -b / (2 * a);
    Console.WriteLine($"La solution dans R est {s0}");
}
else
{
    double s1 = (-b + (Math.Sqrt(d)) / 2 * a);
    double s2 = (-b - (Math.Sqrt(d)) / 2 * a);

    Console.WriteLine($"Deux solutions possibles pour l'équation  (E): {a}X^2 + {b}X + {c} = 0");
    Console.WriteLine($"La solution dans R est ( S1= {s1}, S1= {s2} )");
}


