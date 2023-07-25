namespace POO2;

class Program
{
    private static void Main(string[] args)
    {
        //Exercice22();
        //Exercice31();
        //Exercice32();
        //Exercice36();
        //Exercice41();
        //Exercice45();
        //Exercice48();
        //Exercice51();
        //Exercice52();
        Exercice510();
    }

    private static void Exercice510()
    {
        // Initialisation des tableaux connus
        int[] tableau1 = new int[] { 4, 8, 7, 9, 1, 5, 4, 6 };
        int[] tableau2 = new int[] { 7, 6, 5, 2, 1, 3, 7, 4 };

        // Initialisation du tableau contenant les résultats
        int[] tableau3 = new int[8];

        // Remplir le tableau de résultats
        // Solution 1 un peu dégueulasse où on prie de ne pas avoir 10 000 valeurs
        //tableau3[0] = tableau1[0] + tableau2[0];
        //tableau3[1] = tableau1[1] + tableau2[1];
        //tableau3[2] = tableau1[2] + tableau2[2];
        //tableau3[3] = tableau1[3] + tableau2[3];
        //tableau3[4] = tableau1[4] + tableau2[4];
        //tableau3[5] = tableau1[5] + tableau2[5];
        //tableau3[6] = tableau1[6] + tableau2[6];
        //tableau3[7] = tableau1[7] + tableau2[7];

        // Solution 2
        for (int i = 0; i < 8; i++)
        {
            tableau3[i] = tableau1[i] + tableau2[i];
        }

        // Afficher le tableau de résultats
        foreach (int item in tableau3)
        {
            Console.WriteLine(item);
        }
    }

    private static void Exercice52()
    {
        string[] alphabetLatin = new string[] { "a", "e", "i", "o", "u", "y" };

        Console.WriteLine($"L'alphabet latin contient {alphabetLatin.Length} voyelles");
    }

    private static void Exercice51()
    {
        int[] mesEntiers = new int[7];

        // Liste d'entier. Moins performant que le tableau, mais a l'avantage de pouvoir
        // contenir autant de valeurs qu'on veut
        List<int> maListeInt = new List<int>();
        maListeInt.Add(2);

        // Solution 1 :
        //mesEntiers[0] = 3;
        //mesEntiers[1] = 3;
        //mesEntiers[2] = 3;
        //mesEntiers[3] = 3;
        //mesEntiers[4] = 3;
        //mesEntiers[5] = 3;
        //mesEntiers[6] = 3;

        // Solution 2 :
        for (int i = 0; i < 7; i++)
        {
            mesEntiers[i] = 3;
        }

        // Solution 3 :
        int[] mesEntiersPredefinis = new int[] { 3, 3, 3, 3, 3, 3, 3 };


        // Affichage des entrées du tableau 

        //for (int i = 0; i < 7; i++)
        //{
        //    Console.WriteLine(mesEntiers[i]);
        //}

        foreach (int entierCourant in mesEntiers)
        {
            Console.WriteLine(entierCourant);
        }
    }

    private static void Exercice48()
    {
        int maxNumber = int.MinValue;
        int positionMaxNumber = -1;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Entrez le nombre numéro {i} :");
            int nombre = int.Parse(Console.ReadLine());

            if (nombre > maxNumber)
            {
                maxNumber = nombre;
                positionMaxNumber = i;
            }
        }

        Console.WriteLine($"Le nombre le plus grand est {maxNumber}");
        Console.WriteLine($"Sa position est : {positionMaxNumber}");
    }

    private static void Exercice45()
    {
        // Saisie du nombre
        Console.WriteLine("Veuillez saisir un nombre pour connaitre sa table de multiplication");
        int nombre = int.Parse(Console.ReadLine());

        // Table de multiplication
        Console.WriteLine($"Voici la table de multiplication de {nombre}");

        for (int multiplicateur = 1; multiplicateur <= 10; multiplicateur++)
        {
            int produit = nombre * multiplicateur;
            Console.WriteLine($"{nombre} x {multiplicateur} = {produit}");

            // Ou bien plus directement
            //Console.WriteLine($"{nombre} x {multiplicateur} = {nombre * multiplicateur}");
        }
    }

    private static void Exercice36()
    {
        // Saisie de l'age de l'enfant
        Console.WriteLine("Veuillez saisir l'âge de l'enfant: ");
        string saisie = Console.ReadLine();

        // Conversion de l'age en entier (int)
        int age = int.Parse(saisie);

        // Tests - Solution 1 : égalités strictes. Le plus simple à lire, mais le moins optimisé
        if (age < 6)
        {
            Console.WriteLine("En dehors des catégories possibles");
        }
        else if (age == 6 || age == 7)
        {
            Console.WriteLine("Poussin");
        }
        else if (age == 8 || age == 9)
        {
            Console.WriteLine("Pupille");
        }
        else if (age == 10 || age == 11)
        {
            Console.WriteLine("Minime");
        }
        else
        {
            Console.WriteLine("Cadet");
        }

        // Tests - Solution 2 : optimisé pour des plages plus grandes
        if (age < 6)
        {
            Console.WriteLine("En dehors des catégories possibles");
        }
        else if (age >= 6 && age <= 7)
        {
            Console.WriteLine("Poussin");
        }
        else if (age >= 8 && age <= 9)
        {
            Console.WriteLine("Pupille");
        }
        else if (age >= 10 && age <= 11)
        {
            Console.WriteLine("Minime");
        }
        else
        {
            Console.WriteLine("Cadet");
        }

        // Tests - Solution 3 : plages optimisées ++
        if (age < 6)
        {
            Console.WriteLine("En dehors des catégories possibles");
        }
        else if (age <= 7)
        {
            Console.WriteLine("Poussin");
        }
        else if (age <= 9)
        {
            Console.WriteLine("Pupille");
        }
        else if (age <= 11)
        {
            Console.WriteLine("Minime");
        }
        else
        {
            Console.WriteLine("Cadet");
        }

        // Tests - Solution 4 : switch. Lisible, mais pas de gestion des plages. Pratique sur les énumération (DayOfWeek)
        switch (age)
        {
            case 6:
            case 7:
                Console.WriteLine("Poussin");
                break;
            case 8:
            case 9:
                Console.WriteLine("Pupille");
                break;
            case 10:
            case 11:
                Console.WriteLine("Minime");
                break;
            default:
                if (age >= 12)
                    Console.WriteLine("Cadet");
                else
                    Console.WriteLine("Hors catégorie");
                break;
        }
    }

    private static void Exercice32()
    {
        // Saisie du 1er nombre
        Console.WriteLine("Veuillez saisir un premier nombre");
        string saisie = Console.ReadLine();

        // Saisie du 2e nombre
        Console.WriteLine("Veuillez saisir un deuxième nombre");
        string puma = Console.ReadLine();

        // Conversion des saisies en int
        int nombre1 = int.Parse(saisie);
        int nombre2 = int.Parse(puma);

        // Test - Solution 1
        int multiplication = nombre1 * nombre2;
        if (multiplication > 0)
        {
            AfficherPositif();
        }
        else
        {
            AfficherNegatif();
        }

        // Test - Solution 2 : les deux sont positifs ou les deux sont négatifs -> positif, sinon négatif
        bool lesDeuxPositifs = nombre1 >= 0 && nombre2 >= 0;
        bool lesDeuxNegatifs = nombre1 < 0 && nombre2 < 0;

        if (lesDeuxPositifs || lesDeuxNegatifs)
        {
            AfficherPositif();
        }
        else
        {
            AfficherNegatif();
        }

        // Test - Solution 3 : L'un ou l'autre est négatif mais pas les deux -> négatif, sinon positif
        if (nombre1 < 0 ^ nombre2 < 0)
        {
            AfficherNegatif();
        }
        else
        {
            AfficherPositif();
        }
    }

    private static void AfficherPositif()
    {
        Console.WriteLine("Le résultat est positif");
        // Bug corrigé
    }

    private static void AfficherNegatif()
    {
        Console.WriteLine("Le résultat est négatif");
    }

    private static void Exercice31()
    {
        // Demander un nombre à l'utilisateur. Nous donnera un string
        Console.WriteLine("Veuillez saisir un nombre: ");
        string saisie = Console.ReadLine();

        // Convertir ce string en int
        int nombre = int.Parse(saisie);

        // if ... else
        if (nombre > 0)
            Console.WriteLine("Ce nombre est positif");
        else if (nombre == 0)
            Console.WriteLine("Ce nombre est égal à zéro");
        else
            Console.WriteLine("Ce nombre est négatif");

        Console.WriteLine("2e instruction sans accolade");


        //===================================================================

        if (nombre > 0)
            Console.WriteLine("Ce nombre est positif");
        if (nombre == 0)
            Console.WriteLine("Ce nombre est égal à zéro");
        if (nombre < 0)
            Console.WriteLine("Ce nombre est négatif");
    }

    static void Exercice22()
    {
        // Demander le nombre à l'utilisateur
        Console.WriteLine("Veuillez saisir un nombre :");
        string saisieUtilisateur = Console.ReadLine();

        // Calcul du carré
        int nombre = int.Parse(saisieUtilisateur);
        int carre = nombre * nombre;

        // Affichage du résultat
        Console.WriteLine("Le carré de ce nombre est :");
        Console.WriteLine(carre);
    }

    private static void Exercice6()
    {
        int verreBleu = 10;
        int verreVert = 20;
        int temp = 0;

        Console.WriteLine(temp);

        temp = verreVert;
        verreVert = verreBleu;
        verreBleu = temp;

        Console.WriteLine("Mon verre bleu contient : ");
        Console.WriteLine(verreBleu);
        Console.WriteLine("Mon verre vert contient : ");
        Console.WriteLine(verreVert);
    }

    private static void Exercice7()
    {
        // verreBleu => verreVert
        // verreVert => verreJaune
        // verreJaune => verreBleu

        int verreBleu = 10;
        int verreVert = 20;
        int verreJaune = 30;
        int temp = 0;

        Console.WriteLine(temp);

        temp = verreVert;
        verreVert = verreBleu;
        verreBleu = verreJaune;
        verreJaune = temp;

        Console.WriteLine("Mon verre bleu contient : ");
        Console.WriteLine(verreBleu);
        Console.WriteLine("Mon verre vert contient : ");
        Console.WriteLine(verreVert);
        Console.WriteLine("Mon verre jaune contient : ");
        Console.WriteLine(verreJaune);
    }

    static void DemoConcatenation()
    {
        string chaine1 = "Toto";
        string chaine2 = " part en bateau ";
        int nombre = 4;
        string chaine3 = " fois";

        string phrase = chaine1 + chaine2 + nombre + chaine3;

        int nombre1 = 1;
        string nombre2 = "9";

        int resultat = nombre1 + int.Parse(nombre2);

    }

    static void ExercicePrecedent()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Salut");

        Console.WriteLine("Salut");

        // Déclaration de ma variable
        int monEntier;
        int toto = 34;
        // string titi = "34";



        // Affectation d'une valeur à ma variable
        monEntier = toto + 1;


        Console.WriteLine(monEntier); // 35 ?

        monEntier = monEntier + 10;


        Console.WriteLine(monEntier);
        Console.WriteLine(toto);
    }

    static bool GetNombreAndCheckNombre(out int nombre)
    {
        // Get nombre
        Console.WriteLine("Veuillez saisir un nombre entre 1 et 3 (inclus) :");
        string saisie = Console.ReadLine();

        // Conversion
        bool isSuccess = int.TryParse(saisie, out nombre);

        bool saisieValideDansLintervale = isSuccess && nombre >= 1 && nombre <= 3;
        // Check nombre

        return saisieValideDansLintervale;
    }

    static void Exercice41()
    {
        // Demande de saisie entre 1 et 3 (inclus)
        int nombre = 0;

        bool saisieValide = GetNombreAndCheckNombre(out nombre);

        // Controle de saisie
        while (!saisieValide)
        {
            saisieValide = GetNombreAndCheckNombre(out nombre);
        }


        // Affichage de la saisie contrôlée
        Console.WriteLine($"Bravo ! Vous avez saisi {nombre}");
    }
}