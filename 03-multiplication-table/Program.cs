Console.WriteLine("=========== Table de multiplication ========\n\n\n");

Console.Write("Je veux la table de multiplication par: ");
int.TryParse(Console.ReadLine(), out int a);

Console.Write($"La table de {a} ira de 0 à ");
int.TryParse(Console.ReadLine(), out int b);

for (int j = 0; j <= b; j++)
{
    Console.WriteLine($"{a} x {j} = {a * j}");
}