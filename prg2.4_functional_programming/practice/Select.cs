using System;
using System.Linq;
using System.Collections.Generic;

namespace prg2._4_functional_programming
{
    public static class Select
    {
        public static void run()
        {
            List<string> words = new List<string>();
            Console.WriteLine("Enter a sentence.");
            string sentence = Console.ReadLine();
            words = sentence.Split(new char[]{' '}).ToList();

            foreach(string word in words)
            {
                Console.Write(word + " ");
            }

            List<string> changedWords = words.Select(word => word.ToLower() == "yah" ? "yah yeet" : word).ToList();
            List<string> approvedWords = words.Where(word => word.ToLower() == "yah").ToList();

            Console.WriteLine();

            foreach(string word in approvedWords)
            {
                Console.Write(word);
            }
        }
    }
}