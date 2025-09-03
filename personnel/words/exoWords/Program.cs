using System.Linq;

namespace exoWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

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
            words2.OrderByDescending(word => word).ToList().ForEach(word => Console.WriteLine(word));
        }
    }
}