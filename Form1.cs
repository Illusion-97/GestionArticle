using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GestionArticle
{
    public partial class Form1 : Form,IGestionArticle
    {
        private List<Article> stock;
        public Form1()
        {
            Icon = Icon.FromHandle(((Bitmap)Image.FromFile("icon.png")).GetHicon());
            InitializeComponent();
            InitAticles();
        }

        private void InitAticles()
        {
            try
            {
                using (FileStream f = new FileStream("arts.xml", FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Article>));
                    stock = (List<Article>)xml.Deserialize(f);
                }
            }
            catch (Exception)
            {
                string[] arts = { };
                using (StreamReader stream = new StreamReader("arts.txt"))
                {
                    arts = stream.ReadToEnd().Split(',');
                }
                stock = new List<Article>();
                Random rand = new Random();
                foreach (string art in arts)
                {
                    stock.Add(new Article(art, Math.Round(rand.NextDouble() + rand.Next(50), 2), rand.Next(500)));

                }
            }
            AfficherListArticle(stock);
        }

        private void Save()
        {
            using (FileStream f = new FileStream("arts.xml", FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Article>));
                xml.Serialize(f, stock);
            }
        }

        public void AfficherListArticle(List<Article> articles)
        {
            List<string> names = new List<string>(), nums = new List<string>();
            List<double> prices = new List<double>();
            afficheList.Rows.Clear();
            foreach(Article art in articles)
            {
                names.Add(art.nom);
                prices.Add(art.prix);
                nums.Add(art.numero.ToString());
                string[] row = {art.numero.ToString(), art.nom, art.quantite.ToString(), art.prix.ToString() + " €" };
                afficheList.Rows.Add(row);
            }
            nameTB.AutoCompleteCustomSource.Clear();
            nameTB.AutoCompleteCustomSource.AddRange(names.ToArray());
            numTB.AutoCompleteCustomSource.Clear();
            numTB.AutoCompleteCustomSource.AddRange(nums.ToArray());
            minTB.Text = prices.Min().ToString();
            maxTB.Text = prices.Max().ToString();
        }

        public void AjouterArticle(List<Article> articles, Article article)
        {
            throw new NotImplementedException();
        }
        public List<Article> Rechercher(List<Article> lst, int num)
        {
            List<Article> found = new List<Article>();
            foreach(Article art in lst)
            {
                if (art.numero.ToString().Contains(num.ToString())) found.Add(art);
            }
            return found;
        }

        public List<Article> RechercherArticlesIntervallePrix(List<Article> stock, double min, double max)
        {
            List<Article> found = new List<Article>();
            foreach (Article art in stock)
            {
                if (art.prix >= min && art.prix <= max) found.Add(art);
            }
            return found;
        }

        public List<Article> RechercherArticlesParNom(List<Article> stock, string nom)
        {
            List<Article> found = new List<Article>();
            foreach (Article art in stock)
            {
                if (art.nom.Contains(nom)) found.Add(art);
            }
            return found;
        }

        public void supprimerArticle(List<Article> lst, Article art)
        {
            stock.Remove(art);
        }

        private void nameClear_Click(object sender, EventArgs e)
        {
            nameTB.Text = "";
            AfficherListArticle(stock);
        }

        private void numClear_Click(object sender, EventArgs e)
        {
            numTB.Text = "";
            AfficherListArticle(stock);
        }

        private void priceClear_Click(object sender, EventArgs e)
        {
            minTB.Text = "";
            maxTB.Text = "";
            AfficherListArticle(stock);
        }

        private void nameSearch_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "") AfficherListArticle(RechercherArticlesParNom(stock, nameTB.Text));
            else AfficherListArticle(stock);
        }

        private void numSearch_Click(object sender, EventArgs e)
        {
            try { AfficherListArticle(Rechercher(stock, int.Parse(numTB.Text))); }
            catch (Exception) {numClear_Click(sender,e); }
        }

        private void priceSearch_Click(object sender, EventArgs e)
        {
            try { AfficherListArticle(RechercherArticlesIntervallePrix(stock, double.Parse(minTB.Text), double.Parse(maxTB.Text))); }
            catch (Exception) { priceClear_Click(sender,e); }
}

        private void addClear_Click(object sender, EventArgs e)
        {
            addNomTB.Text = "";
            addNumTB.Text = "";
            addPriceTB.Text = "";
            addQteTB.Text = "";
            AfficherListArticle(stock);
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            try 
            { 
                stock.Add(new Article(addNomTB.Text, double.Parse(addPriceTB.Text), int.Parse(addQteTB.Text)));
                AfficherListArticle(stock);
            }
            catch (Exception) { addClear_Click(sender, e); }
        }

        private void delClear_Click(object sender, EventArgs e)
        {
            delNumTB.Text = "";
            AfficherListArticle(stock);
        }

        private void delOK_Click(object sender, EventArgs e)
        {
            try
            {
                List<Article> found = Rechercher(stock, int.Parse(delNumTB.Text));
                if (found.Count == 1)
                {
                    supprimerArticle(stock,found.ElementAt(0));
                    AfficherListArticle(stock);
                }
                else { AfficherListArticle(found); }
            } catch (Exception) { delClear_Click(sender,e); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }
    }
}
