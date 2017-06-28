using System;
using System.Collections.Generic;

namespace Urgence_Finale_Formation_Neo
{
    /*
     * Cette classe représente un jeu de cartes et tout ce que l'on peut faire avec pour jouer.
     * Elle doit contenir une liste de cartes pour pouvoir jouer.
    */
    class Jeu
    {
        // Tu dois déclarer ici la liste de cartes.
        // Boop!

        // Le constructeur doit créer et remplir la liste de carte (une de chaque valeur pour chaque enseigne).
        // Indice : pour utiliser des informations de la classe Carte, tu peux les trouver en faisant Carte.EnseigneListe par exemple.
        public Jeu()
        {
            // Boop!
        }

        // Tu dois créer la fonction "Afficher" qui doit afficher toutes les cartes restantes dans ce jeu,
        // suivi du nombre de cartes restantes.
        // Indice : n'y a-t-il pas une fonction du même nom dans la classe Carte ?
        // Boop!

        // Cette fonction doit permettre de distribuer la première carte du jeu à quelqu'un.
        // Indice : une fois qu'une carte a été distribuée, elle ne doit pas rester dans le jeu de carte.
        public Carte Distribuer()
        {
            // Boop!
        }

        // Cette fonction doit mélanger les cartes restantes dans ce jeu.
        // Indice : une façon de mélanger un jeu de cartes et d'échanger les places de deux cartes au hasard
        // et de recommencer un grand nombre de fois (1000 fois par exemple).
        public void Melanger()
        {
            // Je te laisse ça pour t'aider.
            Random rnd = new Random();

            // Pour obtenir un nombre aléatoire entre 0 et x (0 inclus et x exclu) tu dois faire :
            // rnd.Next(x);
            // Boop!
        }
    }
}
