using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Algos
{
    public class fib
    {
        public int CalcFib(int N)
        {
            if (N <= 1) return N;
            //if (N == 2) return 1;
          //  if (N < 0) return -1;
            return CalcFib(N - 1) + CalcFib(N - 2);
        }
    }
}
