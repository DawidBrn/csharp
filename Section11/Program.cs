using System;
using System.Collections.Generic;

namespace Section11
{
    class Program
    {
        static List<int>  elements = new List<int> { 4, 5, 1, 3, 2 };
        static int[] array = new int[8] { 22, 21, 34, 55, 69, 73, 84, 101 };
        //linear search (searching from the bigging to the end of data set), simple but not optimal for big collections of data
        static int linearSearch (List<int > elements, int x)
        {
            int length = elements.Count;
            for( int i = 0; i<length; i++)
            {
                if (elements[i] == x) return i;
            }
            return -1;
        }
        //binary search (data collection must be sorted and have direct access to elements), 
        static int binarySearch(List<int> elements , int x)
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (int)((start + stop) / 2);
            while (elements[middle] != x && start < stop)
            { 
                if(x < elements[middle])
                {
                    stop = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
                middle = (int)((start + stop) / 2);

            }
            return (elements[middle] != x) ? -1 : middle;
        }
        //interpolation search ( data collection needs to be sorted and uniformly distributed) 
        static int interpolationSearch(int[] arr ,int length, int x )
        {
            int low = 0;
            int high = length - 1;
            while(low <= high && x>= arr[low] && x<= arr[high])
            {
                if (low == high)
                {
                    if (arr[low] == x)
                        return low;
                    else return -1;
                }
                

            //formula for probing the position of x 
            int pos = low + (high - low) / (arr[high] - arr[low]) * (x - arr[low]);

            if(arr[pos] == x)
            {
                return pos;
            }
            if (arr[pos] < x)
            {
                low = pos + 1;
            }
            else
                high = pos - 1;

            }
            return -1;
        }
        //selection sort, multiple interations , simple , low efficiency
        static int[] selectionSort(int[] arr)
        {
            int len = arr.Length;
            for(int i = 0; i < len; i++)
            {
                int minIndex = i;
                for(int j = i +1; j <len;j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        //bubble sort, doesnt require large amount of memory, high operation cost
        static int[] bubbleSort(int [] arr )
        {
            int len = arr.Length;
            for(int i = len -1; i>=0; i--)
            {
                for(int j = 1; j<=1;j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j-1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }
            return arr;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(linearSearch(elements, 7));

            elements.Sort();
            
            Console.WriteLine(binarySearch(elements, 2));

            Console.WriteLine(interpolationSearch(array, array.Length, 84));

            Console.WriteLine("Array unsorted :");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("select sort:" + "\n");
            int[] tempArray = array;
            selectionSort(tempArray);
            foreach (int i in tempArray)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
