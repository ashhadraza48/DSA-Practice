// See https://aka.ms/new-console-template for more information
using HashingPractice;


//Problem1
Console.WriteLine("Problem 1");
Problem1_Sol obj = new Problem1_Sol();


int[] arr = { 1, 3, 2, 4, 1, 3, 2, 5, 3, 2 };
obj.PrintArrayElementFreq(arr);

//Problem2
Console.WriteLine("Problem 2");
Problem2_Sol obj2 = new Problem2_Sol();
obj2.PrintArrayMostFreqElement(arr);
Console.ReadLine();
