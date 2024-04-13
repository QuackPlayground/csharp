using System;
using System.Collections;


namespace LearnDictionaries
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry Allen", "Flash");

            superheroes.Remove("Barry Allen");

            // get numbers of key-value in dictionaries
            Console.WriteLine("Count: {0}", superheroes.Count);
            Console.WriteLine("Clark kent : {0}", superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Bruce Wayne", out string test); 
            // if it there than test will be "Batman", but if it isn't than test will be null
            Console.WriteLine($"Bruce Wayne: {test}");

            foreach(KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0}: {1}", 
                    item.Key, item.Value);
            }

            superheroes.Clear();
        }
    }
}