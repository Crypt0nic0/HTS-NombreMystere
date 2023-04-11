const int nbMyst = 38;
int nbChoisi = 0;
List<int> list = new List<int> { };
string indication = "";

Console.WriteLine("====== BIENVENU DANS LE NOMBRE MYSTERE ======");
Console.WriteLine("Saisir votre pseudo : ");
string pseudo = Console.ReadLine();
bool trouv = false;

while (!trouv)
{
    Console.Clear();
    Console.Write("Liste des chiffres déjà utilisés : ");
    foreach (int chiffre in list)
    {
        Console.Write($"{chiffre} ");
    }
    Console.WriteLine($"  - {indication}");
    Console.WriteLine($"{pseudo}, devinez le nombre mystere : ");
    nbChoisi = int.Parse(Console.ReadLine());
    if (nbChoisi == nbMyst)
    {
        trouv = true;
        Console.WriteLine($"Félicitations {pseudo}, vous avez trouvé !");
    }
    else
    {
        if (nbChoisi > nbMyst)
        {
            indication = ("Le nombre mystère est plus petit !");
        }
        else
        {
            indication = ("Le nombre mystère est plus grand !");
        }
        list.Add(nbChoisi);
    }
}