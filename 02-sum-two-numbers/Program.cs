// See https://aka.ms/new-console-template for more information
Console.WriteLine("Entrez un nombre :");
string firstInput = Console.ReadLine();

Console.WriteLine("Entrez un deuxieme nombre :");
string secondInput = Console.ReadLine();

if (int.TryParse(firstInput, out int number) && int.TryParse(secondInput, out int number))
{
    int firstIput = number;
}
else
{
    Console.WriteLine("Erreur : Entrée invalide. Veuillez saisir un nombre valide.");
}

// Console.WriteLine($"Le résultat de {number} * 2 est : {result}");

