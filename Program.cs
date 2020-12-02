using System;
using Sorting;
namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,6,2,8,3};
            QuickSort.Sort(a,0,a.Length-1);
        }
    }
}
