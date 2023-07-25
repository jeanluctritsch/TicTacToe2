using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    class Morpion 
    {
        /// <summary>
        /// Affiche le nom du joueur courant
        /// </summary>
        /// <param name="joueur">Nom du joueur à afficher</param>
        private static void AfficherJoueur(string joueur)
        {
            Console.WriteLine("====================");
            Console.WriteLine($"===   Joueur {joueur}   ===");
            Console.WriteLine("====================");
        }

        private static void AfficherPlateau(string[] tableauAAfficher)
        {
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {tableauAAfficher[0]}  |  {tableauAAfficher[1]}  |  {tableauAAfficher[2]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {tableauAAfficher[3]}  |  {tableauAAfficher[4]}  |  {tableauAAfficher[5]} ");
            Console.WriteLine($"_____|_____|_____");
            Console.WriteLine($"     |     |    ");
            Console.WriteLine($"  {tableauAAfficher[6]}  |  {tableauAAfficher[7]}  |  {tableauAAfficher[8]} ");
            Console.WriteLine($"     |     |    ");
        }

        private static void Main(string[] args)
        {
            string[] tableau = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            int compteurTour = 0;

            while (!VainqueurOuEgalite(tableau))
            {
                bool tourPair = compteurTour % 2 == 0;

                // opérateur ternaire
                string joueurCourant = tourPair ? "X" : "O";

                // équivalent de l'opérateur ternaire
                //if (tourPair)
                //{
                //    joueurCourant = "X";
                //}
                //else
                //{
                //    joueurCourant = "O";
                //}

                AfficherJoueur(joueurCourant);
                AfficherPlateau(tableau);

                Console.WriteLine("Choisissez une case");
                int choixJoueur = int.Parse(Console.ReadLine());

                bool isHorsLimite = choixJoueur > 8 || choixJoueur < 0;

                if (!isHorsLimite)
                {
                    string valeurCaseChoisie = tableau[choixJoueur];
                    bool isCaseInvalide = valeurCaseChoisie == "X" || valeurCaseChoisie == "O";

                    if (isCaseInvalide)
                    {
                        Console.WriteLine("Saisie invalide, sélectionnez une autre case");
                    }
                    else
                    {
                        tableau[choixJoueur] = joueurCourant;

                        compteurTour++;
                    }
                }
                else
                {
                    Console.WriteLine("Arrêtez d'être cons ! Cordialement");
                }
            }

            Console.WriteLine("Détection d'un vainqueur ! Bravo !");
        }

        private static bool VainqueurOuEgalite(string[] tab)
        {
            bool vainqueurLigne1 = tab[0] == tab[1] && tab[1] == tab[2];
            bool vainqueurLigne2 = tab[3] == tab[4] && tab[4] == tab[5];
            bool vainqueurLigne3 = tab[6] == tab[7] && tab[7] == tab[8];
            bool vainqueurDiagonale4 = tab[0] == tab[4] && tab[4] == tab[8];
            bool vainqueurDiagonale5 = tab[2] == tab[4] && tab[4] == tab[6];
            bool vainqueurColonne6 = tab[0] == tab[3] && tab[3] == tab[6];
            bool vainqueurColonne7 = tab[1] == tab[4] && tab[4] == tab[7];
            bool vainqueurColonne8 = tab[2] == tab[5] && tab[5] == tab[8];

            //bool egalite = ;

            bool vainqueurQuelconque =
                vainqueurLigne1
                || vainqueurLigne2
                || vainqueurLigne3
                || vainqueurDiagonale4
                || vainqueurDiagonale5
                || vainqueurColonne6
                || vainqueurColonne7
                || vainqueurColonne8;

            return vainqueurQuelconque; // || egalite;
        }
    }
}
