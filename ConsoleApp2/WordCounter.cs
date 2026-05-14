using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class WordCounter
    {
        public static Dictionary<string, int> CountWords(string text)
        {
            char[] delimiters = new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r' };
            string[] words = text.Split(delimiters);

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string normalizedWord = word.ToLower();

                if (wordCounts.ContainsKey(normalizedWord))
                {
                    wordCounts[normalizedWord]++;
                }
                else
                {
                    wordCounts[normalizedWord] = 1;
                }
            }

            return wordCounts;
        }
        public static void PrintDictionary(Dictionary<string, int> wordCounts)
        {
            foreach (var (word, count) in wordCounts)
            {
                Console.WriteLine($"Слово \"{word}\" встречается {count}");
            }
        }
    }
}
