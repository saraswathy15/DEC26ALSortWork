using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEC26ALSortWork
{
    internal class ExInsertSort
    {
        static void ISort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];// key 5
                int j = i - 1;// -1
                // move elements of arr[0 -- to i-1] that is greater than key, to one position ahead of current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;//j--    --j
                }
                arr[j + 1] = key;//5 is pushed to in place of 4 that 2 position
            }
        }
        static void PrintInsertSortArr(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 4, 2, 3 }; 
            Console.WriteLine("before Insert Sort");
            PrintInsertSortArr(nums);
            Console.WriteLine("after Insert Sort");
            ISort(nums);
            PrintInsertSortArr(nums);
        }
    }
}
