using System;//root or base namespace
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace Dec26ALSortWork
{
    internal class Program
    {
        static void BSort(int[] arr)
        {
            int temp = 0;
            int n = arr.Length;//read only property
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])//shift locations
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintAfterBSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // Console.WriteLine();//using allows only namespace but not class names
            int[] arr = { 4, 2, 1, 8, 3 };
            Console.WriteLine("print of before Bubble sort");
            PrintAfterBSort(arr);
            Console.WriteLine("print after Bubble sort");
            BSort(arr);
            PrintAfterBSort(arr);
        }
    }
}
