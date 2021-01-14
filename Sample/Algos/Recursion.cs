using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Algos
{
   public class Recursion
   {
       //O(n) time and space complexity
        public int Sum(int n)
        {
            if (n == 1) return 1;
            return Sum(n - 1) + n;
        }
        
    }
}
