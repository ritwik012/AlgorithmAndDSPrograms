using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class Permutations
    {
        public static void Permutate(string str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    Permutate(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }
        public static string Swap(string word, int i, int j)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string result = new string(charArray);
            return result;
        }
    }
}