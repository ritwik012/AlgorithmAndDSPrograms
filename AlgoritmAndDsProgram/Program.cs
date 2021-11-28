using System;

namespace AlgorithmAndDSPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Algorithm and Data Structures Programs");
                Console.WriteLine("choose the program to be executed : \n 1. Permutations \n 2. Binary Search \n 3. Insertion sort \n 4. Bubble Sort \n 5. Merge Sort \n 6. Anagram \n 7. Prime Numbers Range \n 13. Unordered List \n 16. Banking Cash Counter \n 17. Palindrome Checker \n 18. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter a word to find its permutations : ");
                        string str = Console.ReadLine();
                        Console.WriteLine("**********");
                        Permutations.Permutate(str, 0, str.Length - 1);
                        break;
                    case 2:
                        BinarySearch bin = new BinarySearch();
                        bin.BinarySort();
                        break;
                    case 3:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Insertion();
                        break;
                    case 4:
                        BubbleSort bubbleSort = new BubbleSort();
                        int[] integers = { 73, 27, 81, 34, 2, 50, 63, 69 };
                        bubbleSort.Bubble(integers);
                        break;
                    case 5:
                        MergeSort mergeSort = new MergeSort();
                        int[] arr = { 32, 12, 9, 65, 24, 5 };
                        Console.WriteLine("******** Before Sorting ********");
                        mergeSort.PrintArray(arr);
                        mergeSort.Sort(arr, 0, arr.Length - 1);
                        Console.WriteLine("******** After Sorting ********");
                        mergeSort.PrintArray(arr);
                        break;
                    case 6:
                        Anagram anagram = new Anagram();
                        anagram.Check();
                        break;
                    case 7:
                        PrimeNumbersRange range = new PrimeNumbersRange();
                        range.Prime();
                        break;
                    case 13:
                        UnorderedList unlist = new UnorderedList();
                        unlist.UnList();
                        break;
                    case 16:
                        BankingCashCounter bank = new BankingCashCounter();
                        bank.CashCounter();
                        break;
                    case 17:
                        AlgorithmAndDSPrograms.Utility.PalindromeChecker.Palindrome();
                        break;
                    case 18:
                        flag = false;
                        break;
                }
            }
        }
    }
}