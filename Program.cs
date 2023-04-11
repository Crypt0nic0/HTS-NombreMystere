const int nbMyst = 38;
int nbChoisi = 0;

Console.WriteLine("====== BIENVENU DANS LE NOMBRE MYSTERE ======");
Console.WriteLine("Saisir votre pseudo : ");
string pseudo = Console.ReadLine();
Console.WriteLine($"{pseudo}, devinez le nombre mystere : ");
nbChoisi = int.Parse(Console.ReadLine());
if (nbChoisi == nbMyst)
{
    Console.WriteLine($"Félicitations {pseudo}, vous avez trouvé !");
}
else
{
    if (nbChoisi > nbMyst)
    {
        Console.WriteLine("Dommage, le nombre mystère est plus petit !");
    }
    else
    {
        Console.WriteLine("Dommage, le nombre mystère est plus grand !");
    }
}