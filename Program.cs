using Les_enums_structures;

Cartes carte = new Cartes();
carte.cartes = Couleur.Pique;

Console.WriteLine((int)carte.cartes);
Console.WriteLine(carte.cartes);

if(carte.cartes == Couleur.Pique)
{
    Console.WriteLine("C'est pique.");
}

switch (carte.cartes)
{
	case Couleur.Pique:
        Console.WriteLine("C'est noir !");
    break;
    case Couleur.Trefle:
        Console.WriteLine("C'est noir !");
        break;
    case Couleur.Coeur:
        Console.WriteLine("C'est rouge !");
        break;
    case Couleur.Carreau:
        Console.WriteLine("C'est rouge !");
        break;
}

Structure structure = new Structure();
Console.WriteLine(structure.Name);