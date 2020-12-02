using System;
using System.Collections.Generic;
using Sorting;
namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(){1,6,2,8,3};
          // QuickSort.Sort(a,0,a.Count -1);
          // MergeSort.Sort(a,0,a.Count -1);
           foreach(int num in a){
               Console.WriteLine(num);
           }
        }
    }
}
