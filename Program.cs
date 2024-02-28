/*
Author: Vinesh Sangoi
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
    Bubble Sort. 
    No input is required for the script. It will execute without 
    input against pre-populated arrays. 
*/


using System;

class Bubblesort
{
    static void Main()
    {
        int[] arr = { 5, 72, 3, 14, 7, 1 };

        Console.WriteLine("Original Array: " + string.Join(", ", arr));

        BubbleSort(arr);

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements if they are in the wrong order
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
