using System;
using Sample.Algos;
using Sample.Basics;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //int sum = 0;
            //while (i < 100)
            //{
            //    sum = sum + i;
            //    sum = i + sum;
            //    i += 1;
            //}
          
            //Console.WriteLine(sum); //9900
            var recursion = new Recursion();
            var sumResult = recursion.Sum(5);
            var fib = new fib();
            var arrayBasics = new ArrayBasic();
            arrayBasics.CalcArray();
            int[] arr = new int[7] {1, 2, 3, 4, 5, 6, 7};
            BinarySearch binarySearch = new BinarySearch();
            var binResult = binarySearch.CalcBinary(arr, 7);
            Console.Write(binResult);
            //Console.WriteLine(fib.CalcFib(5));
            //Console.WriteLine(sumResult);
        }
    }

 }
