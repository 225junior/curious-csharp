Console.WriteLine("=========== Table de multiplication ========\n");

Console.Write("Je veux la table de multiplication par: ");
int a, b;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Mauvaise saisie. Essayez encore : ");
}


Console.Write($"La table de {a} ira de 0 à ");
while (!int.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Mauvaise saisie. Essayez encore : ");
}

for (int j = 0; j <= b; j++)
{
    Console.WriteLine($"{a} x {j} = {a * j}");
}