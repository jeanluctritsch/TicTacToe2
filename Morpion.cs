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
        /// Affichage donnée de joueur 
        /// </summary>
        /// <param name="joueur"></param>
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

            while (true)
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
        }
    }
}
