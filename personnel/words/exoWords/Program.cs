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


            string[] words = { "i am the winner", "hello", "monde", "vert", "rouge", "bleu", "i am the looser" };

            Console.WriteLine("The winner is : "+words.First());
            Console.WriteLine("The looser is : "+words.Last());
        }
    }
}