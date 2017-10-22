using System;

namespace _02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random current = new Random();

            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int phraseIndex = current.Next(0, phrases.Length);
                int eventIndex = current.Next(0, events.Length);
                int authorIndex = current.Next(0, authors.Length);
                int cityIndex = current.Next(0, cities.Length);

                output = string.Join(" ", phrases[phraseIndex]
                                         , events[eventIndex]
                                         , authors[authorIndex]
                                         , cities[cityIndex]);

                Console.WriteLine(output);
            }
        }
    }
}
