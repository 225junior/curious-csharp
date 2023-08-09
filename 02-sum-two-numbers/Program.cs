Console.WriteLine("=========== Somme de deux nombres ========\n");

Console.WriteLine("Entrez un nombre :");
int firstInput, secondInput;
while (!int.TryParse(Console.ReadLine(), out firstInput))
{
    Console.WriteLine("Mauvaise saisie. Essayez encore : ");
}

Console.WriteLine("Entrez le second nombre :");
while (!int.TryParse(Console.ReadLine(), out secondInput))
{
    Console.WriteLine("Mauvaise saisie. Essayez encore :");
}

Console.WriteLine($"Le résultat de {firstInput} + {secondInput} est : {firstInput + secondInput}");