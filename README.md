# GestionArticle
![Capture](https://user-images.githubusercontent.com/56721402/134518442-b4b196ab-a665-41ca-b94d-97208cb6e4ae.PNG)

# Main changes : 
`
        private void InitAticles()
        {
            try
            {
                using (FileStream f = new FileStream("arts.xml", FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(stock.GetType());
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
                    stock.Add(new Article(art, Math.Round(rand.NextDouble() + rand.Next(350), 2), rand.Next(999)));

                }
            }
            AfficherListArticle(stock);
        }

        private void Save()
        {
            using (FileStream f = new FileStream("arts.xml", FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(stock.GetType());
                xml.Serialize(f, stock);
            }
        }`
