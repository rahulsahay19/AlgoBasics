using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Basics
{
   public class BinarySearch
    {
        public int CalcBinary(int[] arr, int elemToFind)
        {
            //A[5] = [1,5,7,9,11] //array should be sorted
            int low = 0;
            int high = arr.Length - 1;
            while (low<=high)
            {
                var mid = low + ((high - low) / 2);
                if (arr[mid] < elemToFind)
                {
                    //go right
                    low = mid + 1;
                }
                else if (arr[mid] > elemToFind)
                {
                    //go left
                    high = mid - 1;
                }
                else return mid; //element found, returned the index
            }

            return -1; //element not found
        }
    }
}
