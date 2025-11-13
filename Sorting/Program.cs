// See https://aka.ms/new-console-template for more information
using Sorting;



int[] arr = { 4,8,2,4,5 };

Sort sort = new Sort();

sort.SelectionSort(arr);
Console.WriteLine();

sort.BubbleSort(arr);
Console.WriteLine();

sort.InsertionSort(arr);
Console.WriteLine();

sort.PerformMergeSort(arr);
Console.WriteLine();

sort.PerformQuickSort(arr);
Console.WriteLine();

sort.PerformBubbleSortUsingRecursion(arr);

Console.ReadLine();
