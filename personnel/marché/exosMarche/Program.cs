namespace exosMarche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Data> dataList = GenerateData();
            
            Console.WriteLine($"Il y a {PeachCount(dataList)} vendeurs de pêches");
            Console.WriteLine(Watermelon(dataList));
        }

        public static List<Data> GenerateData()
        {
            return new List<Data> {
                new Data(1, "Bornand", "Pommes", 20, "kg", 6.9),
                new Data(1, "Bornand", "Poires", 16, "kg", 3.5),
                new Data(1, "Bornand", "Pastèques", 14, "pièce", 6.0),
                new Data(1, "Bornand", "Melons", 5, "kg", 7.0),
                new Data(2, "Dumont", "Noix", 20, "sac", 8.6),
                new Data(2, "Dumont", "Raisin", 6, "kg", 5.6),
                new Data(2, "Dumont", "Pruneaux", 13, "kg", 8.1),
                new Data(2, "Dumont", "Myrtilles", 12, "kg", 8.9),
                new Data(2, "Dumont", "Groseilles", 12, "kg", 5.2),
                new Data(3, "Vonlanthen", "Pêches", 8, "kg", 8.7),
                new Data(3, "Vonlanthen", "Haricots", 6, "kg", 6.9),
                new Data(3, "Vonlanthen", "Courges", 18, "pièce", 4.3),
                new Data(3, "Vonlanthen", "Tomates", 12, "kg", 9.4),
                new Data(3, "Vonlanthen", "Pommes", 20, "kg", 3.9),
                new Data(4, "Barizzi", "Poires", 5, "kg", 6.3),
                new Data(4, "Barizzi", "Pastèques", 6, "pièce", 2.5),
                new Data(4, "Barizzi", "Melons", 14, "kg", 4.2),
                new Data(4, "Barizzi", "Noix", 20, "sac", 7.5),
                new Data(4, "Barizzi", "Raisin", 15, "kg", 7.2),
                new Data(5, "Blanc", "Pruneaux", 5, "kg", 9.0),
                new Data(5, "Blanc", "Myrtilles", 18, "kg", 5.6),
                new Data(5, "Blanc", "Groseilles", 10, "kg", 2.1),
                new Data(5, "Blanc", "Pêches", 20, "kg", 6.4),
                new Data(5, "Blanc", "Haricots", 9, "kg", 2.9),
                new Data(6, "Repond", "Courges", 12, "pièce", 7.4),
                new Data(6, "Repond", "Tomates", 12, "kg", 4.2),
                new Data(6, "Repond", "Pommes", 15, "kg", 6.5),
                new Data(6, "Repond", "Poires", 18, "kg", 2.4),
                new Data(6, "Repond", "Pastèques", 7, "pièce", 5.7),
                new Data(7, "Mancini", "Pêches", 10, "kg", 2.9),
                new Data(7, "Mancini", "Haricots", 11, "kg", 6.7),
                new Data(7, "Mancini", "Courges", 10, "pièce", 6.4),
                new Data(7, "Mancini", "Tomates", 13, "kg", 1.5),
                new Data(7, "Mancini", "Pommes", 14, "kg", 7.0),
                new Data(8, "Favre", "Poires", 5, "kg", 8.4),
                new Data(8, "Favre", "Pastèques", 5, "pièce", 1.7),
                new Data(8, "Favre", "Haricots", 5, "kg", 3.0),
                new Data(8, "Favre", "Courges", 17, "pièce", 2.0),
                new Data(8, "Favre", "Tomates", 9, "kg", 5.2),
                new Data(9, "Bovay", "Pommes", 13, "kg", 7.7),
                new Data(9, "Bovay", "Poires", 5, "kg", 3.8),
                new Data(9, "Bovay", "Pastèques", 20, "pièce", 2.1),
                new Data(9, "Bovay", "Melons", 20, "kg", 6.4),
                new Data(9, "Bovay", "Noix", 13, "sac", 8.8),
                new Data(10, "Cherix", "Raisin", 8, "kg", 7.1),
                new Data(10, "Cherix", "Pruneaux", 19, "kg", 7.9),
                new Data(10, "Cherix", "Myrtilles", 9, "kg", 4.2),
                new Data(10, "Cherix", "Groseilles", 10, "kg", 4.4),
                new Data(10, "Cherix", "Pêches", 9, "kg", 4.4),
                new Data(11, "Beaud", "Haricots", 19, "kg", 8.4),
                new Data(11, "Beaud", "Courges", 16, "pièce", 8.7),
                new Data(11, "Beaud", "Tomates", 18, "kg", 5.3),
                new Data(11, "Beaud", "Pommes", 8, "kg", 7.3),
                new Data(11, "Beaud", "Poires", 13, "kg", 9.2),
                new Data(12, "Corbaz", "Pastèques", 15, "pièce", 7.4),
                new Data(12, "Corbaz", "Melons", 12, "kg", 1.6),
                new Data(12, "Corbaz", "Noix", 11, "sac", 7.5),
                new Data(12, "Corbaz", "Raisin", 16, "kg", 4.5),
                new Data(12, "Corbaz", "Pruneaux", 20, "kg", 3.3),
                new Data(13, "Amaudruz", "Myrtilles", 18, "kg", 5.7),
                new Data(13, "Amaudruz", "Groseilles", 19, "kg", 8.0),
                new Data(13, "Amaudruz", "Pêches", 12, "kg", 5.5),
                new Data(13, "Amaudruz", "Haricots", 13, "kg", 5.2),
                new Data(13, "Amaudruz", "Courges", 7, "pièce", 9.6),
                new Data(14, "Bühlmann", "Tomates", 12, "kg", 7.7),
                new Data(14, "Bühlmann", "Pommes", 17, "kg", 1.9),
                new Data(14, "Bühlmann", "Poires", 7, "kg", 3.0),
                new Data(14, "Bühlmann", "Pastèques", 11, "pièce", 6.9),
                new Data(14, "Bühlmann", "Melons", 7, "kg", 4.7),
                new Data(15, "Crizzi", "Noix", 10, "sac", 1.6),
                new Data(15, "Crizzi", "Raisin", 17, "kg", 7.8),
                new Data(15, "Crizzi", "Pruneaux", 18, "kg", 9.0),
                new Data(15, "Crizzi", "Myrtilles", 12, "kg", 3.0),
                new Data(15, "Crizzi", "Groseilles", 12, "kg", 3.5)
            };
        }

        static int PeachCount(List<Data> dataList)
        {
            int count = dataList.Count((data) => data.Produit == "Pêches");
            return count;
        }

        static string Watermelon(List<Data> dataList)
        {
            Data merchant = dataList.Where((data) => data.Produit == "Pastèques").MaxBy(p => p.Quantite); 
            return $"C'est {merchant.Producteur} qui a le plus de pastèques (stand {merchant.Emplacement}, {merchant.Quantite} pièces)";
        }


    }



    class Data
    {
        public int Emplacement;
        public string Producteur;
        public string Produit;
        public int Quantite;
        public string Unite;
        public double prix;
        public Data(int emplacement, string producteur, string produit, int quantite, string unite, double prix)
        {
            this.Emplacement = emplacement;
            this.Producteur = producteur;
            this.Produit = produit;
            this.Quantite = quantite;
            this.Unite = unite;
            this.prix = prix;
        }
    }
}