using System;
using System.Linq;
using Abstracts;

namespace Concretes
{
    public class PermMissingElem : IAlgorithm
    {
        /*
            Given an array A, returns the value of the missing element.
    
            EXAMPLE
                A[0] = 2  A[1] = 3  A[2] = 1
                A[3] = 5
                the function should return 4
    
            RULE:
                N is an integer within the range [0..100,000];
                the elements of A are all distinct;
                each element of array A is an integer within the range [1..(N + 1)].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Odd Occurrences In Array!");
            long[] array = new long[4];
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(Console.ReadLine());
            }
            long result = FindMissingItem(array);
            Console.WriteLine("Output: [{0}]", string.Join(", ", result));
            Console.ReadKey();
        }

        private static long FindMissingItem(long[] A)
        {
            long n = A.Length + 1;
            long sumOfAllElements = (n * (1 + n)) / 2;
            long missingElement = sumOfAllElements - A.Select(x => x).Sum();
            return missingElement;
        }
    }
}
