using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4_delegat
{
    class Program
    {
        static void Main()
        {
            string[] words = { "квас", "тарас", "арканум", "слова", "трататататата" };
            Func<string, int> word_length = s => s.Length;
            foreach (string word in words)
            {
                int l = word_length(word);
                Console.WriteLine(word + " - " + l);
            }
        }
    }
}
