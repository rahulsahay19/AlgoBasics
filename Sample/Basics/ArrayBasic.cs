using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Basics
{
   public class ArrayBasic
    {
        public void CalcArray()
        {
            int[] arr = { 1, 2, 3, 4, 5};
            foreach (var i in arr)
            {
                Console.Title = "Basics";
                Console.WriteLine(i);
            }
        }
    }
}
