using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class Anagram
    {
        public void Check()
        {
            Console.WriteLine("Enter first word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string word2 = Console.ReadLine();
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words {0} and {1} are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words {0} and {1} are not Anagrams", word1, word2);
            }
        }
    }
}