using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class HW1_Array
    {
        public static int GetMinElemArray(int[] array)
        {
            int minArray = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minArray > array[i])
                    minArray = array[i];
            }            
            return minArray;
        }
        public static int GetMaxElemArray(int[] array)
        {
            int maxArray = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxArray < array[i])
                    maxArray = array[i];
            }           
            return maxArray;
        }
        public static int GetMinIndex(int[] array)
        {
            int minIndex = 0;
            int minElem = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minElem > array[i])
                {
                    minElem = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int GetMaxIndex(int[] array)
        {
            int maxIndex = 0;
            int maxElem = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxElem < array[i])
                {
                    maxElem = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static int GetSumOfOddIndex(int[] array)
        {
            int sumOddIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    sumOddIndex += array[i];
            }
            return sumOddIndex;
        }
        public static void ReversArray(int[] array) 
        { 
            Console.Write("Revers of array: ");
            Console.Write("{ ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    Console.Write(array[i] + ", ");
                else if (i == 0)
                    Console.Write(array[i]);
            }
            Console.Write(" }");
        }
        public static int CountOfOddIndex(int[] array)
        {
            int countOddIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    countOddIndex ++;
            }
            return countOddIndex;
        }
        public static void ReversFirtHalfOfArray(int[] array) 
        { 
            Console.WriteLine("Revers first half of array: ");
            Console.Write("{ ");
            int length = array.Length;
            for (int i = length - 1; i >= length / 2; i--)
            {
                Console.Write(array[i] + ", ");
            }
            for (int i = 0; i < (length / 2); i++)
            {
                if (i >= 0 && i != ((length / 2) - 1))
                {
                    Console.Write(array[i] + ", ");
                }
                else if (i == ((length / 2) - 1))
                {
                    Console.Write(array[i]);
                }
            }
            Console.Write("}" + "\n");
        }
        public static int[] BubleSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int min = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = min;
                    }
                }
            }
            return array;            
        }        
        
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                    int temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
            return array;
        }
        public static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 0) && (array[j - 1] > key))
                {
                    var temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
                array[j] = key;
            }
            return array;
        }
    }
}
