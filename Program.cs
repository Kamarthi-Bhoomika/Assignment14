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
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
        }
        public static int[] generateArray()
        {

            Random random = new Random();
            int[] arr = new int[100];
            for(int i =0; i< 100; i++)
            {
                int num = random.Next(0, 1000);
                arr[i] =num;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = generateArray();
            Console.WriteLine("Array Before Sorting");
            Print(arr);
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(arr);
            stopwatch.Stop();
            Console.WriteLine("Array After Bubble Sorting");
            Print(arr);
            Console.WriteLine($"Array Size {arr.Length} \tTime Take {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

            Console.WriteLine("\n***********************************");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            InsertionSort(arr);
            stopwatch2.Stop();
            Console.WriteLine("Array After Insertion Sorting");
            Print(arr);
            Console.WriteLine($"Array Size {arr.Length} \tTime Take {stopwatch2.Elapsed.TotalMilliseconds} milliseconds");

            Console.ReadKey();
        }
    }
}
