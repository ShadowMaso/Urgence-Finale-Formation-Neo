using System;
using System.Collections.Generic;

namespace Urgence_Finale_Formation_Neo
{
    /*
     * Cette classe représente une personne présente à une table de Blackjack.
     * Elle doit contenir une liste de cartes représentant la main de la personne,
     * d'autres propriétés et des fonctions pour pouvoir jouer.
     * Indice : le mot clé "abstract" avant le nom de la classe veut dire qu'on ne peut pas
     * instancier un objet Personne directement, mais on peut instancier un objet héritant de Personne.
    */
    abstract class Personne
    {
        // Une personne doit pouvoir garder les cartes qu'elle pioche en main,
        // savoir son total de points et si elle a des As en main.
        // Tu dois déclarer ici la liste de cartes et les variables stockant le total et le nombre d'As.
        // Personne d'autre ne doit pouvoir accéder à ces informations, ces propriétés ne doivent pas être
        // "public" ou "private" mais "protected" (ce qui veut dire qu'une classe fille peut les utiliser).
        // Boop!

        // Le constructeur doit créer la liste de carte et mettre les autres propriétés à 0.
        public Personne()
        {
            // Boop!
        }

        // Cette fonction doit piocher une carte dans le jeu et l'ajouter à la main de la personne.
        // Quand la carte est piochée, il faut ajouter son score au score total de la personne,
        // si c'est un As, il faut augmenter de un le compteur d'As de la personne.
        // Après avoir pioché la carte, si le score total dépasse 21 et qu'on a au moins un As dans la main,
        // l'As vaut maintenant 1, un déduit 10 au score total et on diminue de 1 le nombre d'As en main.
        // Pour finir, la fonction doit retourner le nom de la carte piochée.
        public string Piocher(Jeu jeu)
        {
            // Boop!
        }

        // Tu dois créer la fonction "Afficher" qui doit afficher les cartes présentes dans la main.
        // Indice : n'y a-t-il pas une fonction du même nom dans la classe Carte ?
        // Boop!

        // Tu dois créer la fonction "ScoreTotal" qui doit retourner le total de points de la personne.
        // Boop!

        // Tu dois créer la fonction "Blackjack" qui doit retourner "true" s'il y a Blackjack, sinon "false".
        // Il y a Blackjack quand la personne a un score de 21 avec seulement deux cartes en main.
        // Boop!

        // Cette fonction doit vider la main de la personne et réinitialiser ses propriétés.
        public void Reinitialiser()
        {
            // Boop!
        }

    }
}
