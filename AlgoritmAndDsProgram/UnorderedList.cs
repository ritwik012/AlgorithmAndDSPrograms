using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class UnorderedList
    {       
        public void UnList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string text = File.ReadAllText(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\AlgorithmAndDSPrograms\AlgorithmAndDSPrograms\Files\Data.txt");
            string[] words = text.Split(" ");
            Console.WriteLine("The Length of the text is {0}", words.Length);
            foreach (string item in words)
            {
                linkedList.AddLast(item);
            }
            Display(linkedList);
            Console.WriteLine("Enter a word to search");
            string search = Console.ReadLine();
            if (linkedList.Contains(search))
            {
                linkedList.Remove(search);
                Console.WriteLine("{0} is removed from the file", search);
            }
            else
            {
                linkedList.AddLast(search);
                Console.WriteLine("{0} is added to the file", search); ;
            }
            File.WriteAllText(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\AlgorithmAndDSPrograms\AlgorithmAndDSPrograms\Files\Data.txt", text);
            Display(linkedList);
        }
        private void Display(LinkedList<string> linkedList)
        {
            foreach(var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}