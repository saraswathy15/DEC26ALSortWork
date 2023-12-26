using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEC26ALSortWork
{
    internal class ExSelectSort
    {
        static void SelectSort(int[] arr)
        { //find the lenght
            int n = arr.Length;
            //one by one move position of unsorted array
            for (int i = 0; i < n - 1; i++)
            {// find the minimum element in the unsorted array
                int ind_min = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[ind_min])
                    {
                        ind_min = j;
                        // swap the minimum element with the first element in array
                        int temp = arr[ind_min];
                        arr[ind_min] = arr[i];
                        arr[i] = temp;
                        // Console.Write(arr[i]+" ");
                    }
                }
            }
        }
        static void PrintSelectSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("testing ");
            int[] nums = { 4, 2, 1, 8, 3 };
            SelectSort(nums);
            PrintSelectSort(nums);
        }
    }
}
