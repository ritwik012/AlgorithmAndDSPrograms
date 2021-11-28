using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class PrimeNumbersRange
    {
        public void Prime()
        {
            Console.WriteLine("Find the prime numbers within a range of numbers : ");
            Console.WriteLine("Input starting number of range : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input ending number of range : ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : ", start, end);
            for (int num = start; num <= end; num++)
            {
                int count = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && num != 1 & num != 0)
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
    }
}