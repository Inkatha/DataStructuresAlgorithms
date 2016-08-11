using System;

namespace MergeSort
{
    public class Merge
    {
        private static int[] aux;

        public static void Sort(int[] a)
        {
            aux = new int[a.Length];
            Sort(a, 0, a.Length - 1);
        }

        private static void Sort(int[] a, int lo, int hi)
        {
            if (hi <= lo)
            {
                return;
            }
            int mid = lo + (hi - lo) / 2;
            Sort(a, lo, mid);
            Sort(a, mid + 1, hi);
            merge(a, lo, mid, hi);
        }

        public static void merge(int[] a, int lo, int mid, int hi)
        {
            int i = lo;
            int j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    a[k] = aux[j++];
                }
                else if (j > hi)
                {
                    a[k] = aux[i++];
                }
                else if (aux[j] < aux[i])
                {
                    a[k] = aux[j++];
                }
                else
                {
                    a[k] = aux[i++];
                }
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Sort(array);
            PrintArray(array);
        }
    }
}
