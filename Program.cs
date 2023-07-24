using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14_BubbleSort
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for(int i = 0; i < n; i++)
            {
                swapped = false;
                for(int j = 0; j < n-1-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine("\n");
        }
        public static int[] generateArray()
        {

            Random random = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                int num = random.Next(0, 1000);
                arr[i] =num;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr1 = generateArray();
            //int[] arr1 = { 55, 599, 985, 919, 292, 571, 9, 106, 685, 369, 944, 589, 751, 685, 535, 717, 74, 785, 908, 744, 17, 456, 108, 598, 134, 307, 205, 31, 120, 832, 183, 834, 122, 500, 217, 0, 278, 296, 110, 491, 734, 190, 636, 202, 207, 285, 853, 881, 623, 328, 525, 476, 744, 851, 918, 599, 491, 386, 784, 984, 366, 978, 985, 852, 185, 109, 466, 251, 468, 534, 439, 777, 675, 417, 10, 827, 819, 905, 391, 848, 454, 324, 407, 792, 307, 707, 90, 271, 581, 617, 509, 892, 511, 125, 125, 756, 205, 784, 16, 97 };
            Console.WriteLine("Array Before Sorting");
            Print(arr1);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr1);
            stopwatch.Stop();
            Console.WriteLine("Array After Bubble Sorting");
            Print(arr1);
            Console.WriteLine($"Array Size {arr1.Length} \tTime Take {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

            Console.WriteLine("\n**********************************************");
            int[] arr2 = generateArray();
            //int[] arr2 = { 55, 599, 985, 919, 292, 571, 9, 106, 685, 369, 944, 589, 751, 685, 535, 717, 74, 785, 908, 744, 17, 456, 108, 598, 134, 307, 205, 31, 120, 832, 183, 834, 122, 500, 217, 0, 278, 296, 110, 491, 734, 190, 636, 202, 207, 285, 853, 881, 623, 328, 525, 476, 744, 851, 918, 599, 491, 386, 784, 984, 366, 978, 985, 852, 185, 109, 466, 251, 468, 534, 439, 777, 675, 417, 10, 827, 819, 905, 391, 848, 454, 324, 407, 792, 307, 707, 90, 271, 581, 617, 509, 892, 511, 125, 125, 756, 205, 784, 16, 97 };
            Console.WriteLine("Array Before Sorting");
            Print(arr2);
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            InsertionSort(arr2);
            stopwatch2.Stop();
            Console.WriteLine("\nArray After Insertion Sorting");
            Print(arr2);
            Console.WriteLine($"Array Size {arr2.Length} \tTime Take {stopwatch2.Elapsed.TotalMilliseconds} milliseconds");

            Console.ReadKey();
        }
    }
}
