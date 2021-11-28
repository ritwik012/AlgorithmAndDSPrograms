using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms.Utility
{
    public class PalindromeChecker
    {
        public static void Palindrome()
        {
            Queue<char> queue = new Queue<char>();
            Console.WriteLine("Enter a String to Check Palindrome");
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(word[i]);
            }
            string reverseWord = "";
            while (!queue.IsEmpty())
            {
                reverseWord = reverseWord + queue.Dequeue();
            }
            if (word.Equals(reverseWord))
            {
                Console.WriteLine("{0} is a Palindrome", word);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome", word);
            }
        }
    }
}