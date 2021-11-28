using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class InsertionSort
    {
        public void Insertion()
        {
            string text = File.ReadAllText(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\AlgorithmAndDSPrograms\AlgorithmAndDSPrograms\Files\String.txt");
            string[] data = text.Split(",");
            string temp;
            Console.WriteLine("******** Before Sorting ********");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            for (int i = 1; i < data.Length; i++)
            {
                temp = data[i];
                int j = i - 1;
                while (j >= 0 && data[j].CompareTo(temp) > 0)
                {
                    data[j + 1] = data[j];
                    j--;
                }
                data[j + 1] = temp;
            }
            Console.WriteLine("******** After Sorting ********");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}