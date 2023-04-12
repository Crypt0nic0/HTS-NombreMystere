const int nbMyst = 7;
const int nbMin = 1;
const int nbMax = 10;
int nbChoisi = 0;
List<int> list = new List<int> { };
string indication = "";
string? pseudo = null;


Console.WriteLine("====== BIENVENU DANS LE NOMBRE MYSTERE ======");

while (pseudo is null || pseudo == "")
{
    Console.WriteLine("Saisir votre pseudo : ");
    pseudo = Console.ReadLine();
}

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

    nbChoisi = 0;
    while (nbChoisi < nbMin || nbChoisi > nbMax)
    {
        Console.WriteLine($"{pseudo}, devinez le nombre mystere (entre {nbMin} et {nbMax}) : ");
        try
        {
            string? nbchoice = Console.ReadLine();
            if (nbchoice is not null)
            {
                nbChoisi = int.Parse(nbchoice);
            }
            else
            {
                nbChoisi = 0;
            }
        }
        catch
        {
            nbChoisi = 0;
            Console.WriteLine("Merci de saisir un entier");
        }
    }

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