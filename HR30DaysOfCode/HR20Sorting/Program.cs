using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        // Write Your Code Here
        int eFirst = 0;
        int eLast = 0;
        int nSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            
            for (int j = 0; j < n - 1; j++)
            {
 
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    //swap(a[j], a[j + 1]);
                    int bigger = a[j];
                    int smaller = a[j + 1];
                    a[j] = smaller;
                    a[j + 1] = bigger;
                    nSwaps++;
                }
                if (nSwaps == 0)
                {
                  //  break; //array is sorted
                }
            }
        }
        eFirst = a[0];
        //eLast = a[n-1];
        eLast = a.Last();
        Console.WriteLine($"Array is sorted in {nSwaps} swaps.");
        //
        Console.WriteLine($"First Element: {eFirst}");
        Console.WriteLine($"Last Element: {eLast}");

    }
}

