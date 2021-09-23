using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArticle
{
    interface IGestionArticle
    {

        /// <summary>
        /// Rechercher un article par son nom dans la liste des articles
        /// </summary>
        /// <param name="stock">liste des articles</param>
        /// <param name="nom">Nom de l'article</param>
        /// <returns>Retourne une liste d'article contenant ce nom</returns>
        List<Article> RechercherArticlesParNom(List<Article> stock, string nom);
        /// <summary>
        /// Recherche les articles comprises entre intervalle de prix
        /// </summary>
        /// <param name="stock"> La liste des articles </param>
        /// <param name="min">prix minimum</param>
        /// <param name="max">prix maximum</param>
        /// <returns> La liste des articles comprises entre le prix min et le prix max</returns>
        List<Article> RechercherArticlesIntervallePrix(List<Article> stock, double min, double max);
        /// <summary>
        /// Methode qui verifie l'exitence d'un article
        /// </summary>
        /// <param name="lst">List d'article</param>
        /// <param name="num">Numéro de l'article</param>
        /// <returns>Retourne les articles avec un numero correspondant</returns>
        List<Article> Rechercher(List<Article> lst, int num);
        /// <summary>
        /// Ajouter un article dans le stock
        /// </summary>
        /// <param name="articles">liste d'article</param>
        /// <param name="article">l'article ajouté</param>
        void AjouterArticle(List<Article> articles, Article article);
        void AfficherListArticle(List<Article> articles);

        /// <summary>
        /// Supprimer un article
        /// </summary>
        /// <param name="lst">stock</param>
        /// <param name="art">article à supprimer</param>
        void supprimerArticle(List<Article> lst, Article art);

    }
}
