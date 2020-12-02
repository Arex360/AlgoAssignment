using System;
using System.Collections;

namespace Sorting {
    public class QuickSort{
        private static int Divide(int[] arr, int low, int high){
            int pivot = arr[high];
            int i = (low -1);
            for(int j = low; j < high;j++){
                if(arr[j] < pivot){
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i+1];
            arr[i+1] = arr[high];
            arr[high] = temp1;
            return i+1;
        }
        public static void Sort(int[] arr, int low , int high){
            if(low < high){
                int pi = Divide(arr,low,high);
                Sort(arr,low,pi-1);
                Sort(arr,pi+1,high); 
            }
        }
    }
}