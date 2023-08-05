Console.WriteLine("=========== Somme de deux nombres ========\n\n\n");

Console.WriteLine("Entrez un nombre :");
string firstInput = Console.ReadLine();

Console.WriteLine("Entrez un deuxieme nombre :");
string secondInput = Console.ReadLine();

if (int.TryParse(firstInput, out int number1) && int.TryParse(secondInput, out int number2))
{
    Console.WriteLine($"Le résultat de {number1} + {number2} est : {number1 + number2}");
}
else
{
    Console.WriteLine("Erreur : Entrée invalide. Veuillez saisir un nombre valide.");
}


