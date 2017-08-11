using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string[] phrases = {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int phrase = rnd.Next(0, phrases.Length);
                int event2 = rnd.Next(0, events.Length);
                int author = rnd.Next(0, authors.Length);
                int city = rnd.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phrase]} {events[event2]} {authors[author]} – {cities[city]}");
            }
        }
    }
}
