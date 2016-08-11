using System;

namespace SelectionSort
{
    class Program
    {
        public static void Sort(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                int lowestIndex = i;
                for (int j = i; j < length; j++)
                {
                    if (array[lowestIndex] > array[j])
                    {
                        lowestIndex = j;
                    }
                }
                Swap(array, lowestIndex, i); 
            }
        }

        public static void Swap(int[] array, int lower, int higher)
        {
            int temp = array[higher];
            array[higher] = array[lower];
            array[lower] = temp;
        }

        public static void PrintArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int[] array = {9, 8, 7, 6, 5, 4, 3, 2, 1};
            Sort(array);
            PrintArray(array);
        }
    }
}
