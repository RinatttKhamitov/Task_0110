using System;
using System.Linq;

namespace test
{
    public struct Zloyded
    {
        public string name;
        public enum Level_grouchiness
        {
            level1 = 1,
            level2 = 2,
            level3 = 3,
            level4 = 4
        }
        public string[] phrases_for_пrumbling;
        public int count_bruises;
        public Zloyded(string name, string[] phrases_for_пrumbling, int count_bruises = 0)
        {
            this.name = name;   
            this.phrases_for_пrumbling = phrases_for_пrumbling;
            this.count_bruises = count_bruises;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1 , 4,65,5 ,343,1 - 101, 4 };
            int[] sortedArray = QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine($"Список = {string.Join(", ", sortedArray)}");

            Console.ReadLine();
        }
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            int copy = 0;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    copy = array[pivot];
                    array[pivot] = array[i];
                    array[i] = copy;

                }
            }

            pivot++;
            copy = array[pivot];
            array[pivot] = array[maxIndex];
            array[maxIndex] = copy;

            return pivot;
        }


    }
}