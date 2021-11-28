using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms
{
    public class MergeSort
    {
        public void Merge(int[] arr, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;
            int[] left = new int[n1];
            int[] right = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
            {
                left[i] = arr[low + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            int k = low;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                int mid = (low + high) / 2;
                Sort(arr, low, mid);
                Sort(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }
        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}