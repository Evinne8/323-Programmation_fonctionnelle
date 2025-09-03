using System.Linq;
using System.Text.RegularExpressions;

namespace exoWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<string> words = new List<string> { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            int x=(int)words.Average(word => word.Length);
            List<string> words2 = words.Where(word => !word.Contains('x') && word.Length > 4 && word.Length == x).ToList();
            Console.WriteLine("\n---------------Liste ordre naturel----------\n");
            words2.ForEach(word => Console.WriteLine(word));
            Console.WriteLine("\n--------Liste ordre naturel inverse---------\n");
            words2.Reverse();
            words2.ForEach(word => Console.WriteLine(word));
            Console.WriteLine("\n---------------Liste ordre a-z--------------\n");
            words2.OrderBy(word => word).ToList().ForEach(word => Console.WriteLine(word));
            Console.WriteLine("\n---------------Liste ordre z-a--------------\n");
            words2.OrderByDescending(word => word).ToList().ForEach(word => Console.WriteLine(word));*/

            /*string[] words = { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };

            words.Where(word => !word.Contains(' ') && !word.Contains('!')).ToList().ForEach(word=>Console.WriteLine(word));*/

            /*string[] words = { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };


            words.Where(word =>!Regex.IsMatch(word, "[@+<>#%]")).ToList().ForEach(word=>Console.WriteLine(word));*/


            /*string[] words = { "i am the winner", "hello", "monde", "vert", "rouge", "bleu", "i am the looser" };

            Console.WriteLine("The winner is : "+words.First());
            Console.WriteLine("The looser is : "+words.Last());*/

            /*List<Lettre> letters = new List<Lettre>
            {
                new Lettre("A", 8.15),
                new Lettre("B", 0.97),
                new Lettre("C", 3.15),
                new Lettre("D", 3.73),
                new Lettre("E", 17.39),
                new Lettre("F", 1.12),
                new Lettre("G", 0.97),
                new Lettre("H", 0.85),
                new Lettre("I", 7.31),
                new Lettre("J", 0.45),
                new Lettre("K", 0.02),
                new Lettre("L", 5.69),
                new Lettre("M", 2.87),
                new Lettre("N", 7.12),
                new Lettre("O", 5.28),
                new Lettre("P", 2.80),
                new Lettre("Q", 1.21),
                new Lettre("R", 6.64),
                new Lettre("S", 8.14),
                new Lettre("T", 7.22),
                new Lettre("U", 6.38),
                new Lettre("V", 1.64),
                new Lettre("W", 0.03),
                new Lettre("X", 0.41),
                new Lettre("Y", 0.28),
                new Lettre("Z", 0.15),
            };

            letters.Where(letter=>letter.percentage> 0.5 && letter.percentage< 0.95).ToList().ForEach(letter=>Console.WriteLine(letter));*/

            List<string> frenchWords = new List<string>() {
                "Merci",
                "Hotdog",
                "Oui",
                "Non",
                "Désolé",
                "Réunion",
                "Manger",
                "Boire",
                "Téléphone",
                "Ordinateur",
                "Internet",
                "Email",
                "Sandwich",
                "Hello",
                "Taxi",
                "Hotel",
                "Gare",
                "Train",
                "Bus",
                "Métro",
                "Tramway",
                "Vélo",
                "Voiture",
                "Piéton",
                "Feu rouge",
                "Cédez",
                "Ralentir",
                "gauche",
                "droite",
                "Continuer",
                "Sandwich",
                "Retourner",
                "Arrêter",
                "Stationnement",
                "Parking",
                "Interdit",
                "Péage",
                "Trafic",
                "Route",
                "Rond-point",
                "Football",
                "Carrefour",
                "Feu",
                "Panneau",
                "Vitesse",
                "Tramway",
                "Aéroport",
                "Héliport",
                "Port",
                "Ferry",
                "Bateau",
                "Canot",
                "Kayak",
                "Paddle",
                "Surf",
                "Plage",
                "Mer",
                "Océan",
                "Rivière",
                "Lac",
                "Étang",
                "Marais",
                "Forêt",
                "Hello",
                "Montagne",
                "Vallée",
                "Plaine",
                "Désert",
                "Jungle",
                "Savane",
                "Volleyball",
                "Tundra",
                "Glacier",
                "Neige",
                "Pluie",
                "Soleil",
                "Nuage",
                "Vent",
                "Tempête",
                "Ouragan",
                "Tornade",
                "Séisme",
                "Tsunami",
                "Volcan",
                "Éruption",
                "Ciel"
            };

            frenchWords.ForEach(word=> word.)

        }

        /*class Lettre
        {
            public string name;
            public double percentage;

            public Lettre (string name, double percentage)
            {
                this.name = name;
                this.percentage = percentage;
            }

            public override string ToString()
            {
                return $"{name} , {percentage}%";
            }
        }*/
    }
}