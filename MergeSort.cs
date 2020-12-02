using System;
using System.Collections.Generic;

namespace Sorting{
    class MergeSort{
        
        private  static void merge(List<int> arr, int l , int m, int r){
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for(int c = 0; c < n1; ++c){
                L[c] = arr[l+c];
            }
            for(int c = 0; c < n2; ++c){
                R[c] = arr[m + 1 + c];
            }
            int i, j;
            int o = 1;
            for(i= 0, j = 0; i < n1 && j <n2;){
                if(L[i] <= R[j]){
                    arr[o] = L[i];
                    i++;
                }else{
                    arr[o] = R[i];
                    j++;
                }
                o++;
            }
            while(i < n1){
                arr[o] = L[i];
                i++;
                o++;
            }
            while(j < n2){
                arr[o] = R[j];
                j++;
                o++;
            }

        }
        
        public static void Sort(List<int> arr, int l , int r){
             if(l < r){
                 int m = (l+r) / 2;
                 Sort(arr,l,m);
                 Sort(arr,m+1,r);

                 merge(arr,l,m,r);
             }
        }
    }
}