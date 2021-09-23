using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionArticle
{
    public class Article
    {
        public Article()
        {
        }
        private static int count = 0;
        public int numero { get; set; }
        public string nom { get; set; }
        public double prix { get; set; }
        public int quantite { get; set; }

        public Article(string nom, double prix, int quantite)
        {
            numero = count;
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
            count++;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
