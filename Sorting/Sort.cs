using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Sort
    {
        #region Common
        private static void Swap(int[] arr, int idx1, int idx2)
        {
            int temp = arr[idx1];
            arr[idx1] = arr[idx2];
            arr[idx2] = temp;
        }

        #endregion Common

        #region SelectionSort

        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                        min = j;
                }
                if (min != i)
                    Swap(arr, min, i);
            }

            Console.WriteLine("Sorted using SelectionSort:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }

        #endregion SelectionSort

        #region BubbleSort

        public void BubbleSort(int[] arr)
        {
            bool isSwapHappen = false;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        isSwapHappen = true;
                    }
                }

                if (!isSwapHappen)
                    break;
            }

            Console.WriteLine("Sorted using BubbleSort:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }

        #endregion BubbleSort

        #region InsertionSort

        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;

                while(j>0 && arr[j] < arr[j - 1])
                {
                    Swap(arr, j, j - 1);
                    j--;
                }
            }

            Console.WriteLine("Sorted using InsertionSort:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }

        #endregion InsertionSort

        #region MergeSort

        public void PerformMergeSort(int[] arr)
        {
            int len = arr.Length;
            MergeSort(arr, 0, len-1);

            Console.WriteLine("Sorted using MergeSort:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }

        private void MergeSort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int mid = (low + high) / 2;
            MergeSort(arr, low, mid);
            MergeSort(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }

        private void Merge(int[] arr, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            int idx = 0;
            int[] temp = new int[high + 1];

            while(left<=mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp[idx] = arr[left];
                    left++;
                    idx++;
                }
                else
                {
                    temp[idx] = arr[right];
                    right++;
                    idx++;
                }
            }

            while (left <= mid)
            {
                temp[idx] = arr[left];
                left++;
                idx++;
            }

            while (right <= high)
            {
                temp[idx] = arr[right];
                right++;
                idx++;
            }

            for(int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
        }

        #endregion MergeSort

        #region QuickSort

        public void PerformQuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted using QuickSort:");
            foreach(var num in arr)
            {
                Console.Write(num + " ");
            }
        }

        private void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                QuickSort(arr, low, partitionIndex-1);
                QuickSort(arr,partitionIndex+1,high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = low;
            int i = low;
            int j = high;

            while (i < j)
            {
                while (arr[i] <= arr[pivot] && i <= high-1)
                {
                    i++;
                }

                while (arr[j] > arr[pivot] && j >= low+1)
                {
                    j--;
                }

                if(i<j)
                    Swap(arr, i, j);

                
            }

            Swap(arr, low, j);
            return j;
        }

        #endregion QuickSort

        #region RecursiveBubbleSort

        public void PerformBubbleSortUsingRecursion(int[] arr)
        {
            BubbleSortusingRecursion(arr, arr.Length - 1);

            Console.WriteLine("Sorted using Recursive BubbleSort:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }

        }

        private void BubbleSortusingRecursion(int[] arr,int n)
        {
            if (n == 1)
                return;

            PlaceSortedElement(arr,n);
            BubbleSortusingRecursion(arr, n - 1);
        }

        private void PlaceSortedElement(int[] arr, int n)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                }
            }
        }

        #endregion RecursiveBubbleSort
    }




}
