using System;
using Abstracts;

namespace Concretes
{
    public class OddOccurrencesInArray : IAlgorithm
    {
        /*
            Given an array A consisting of N integers fulfilling the above conditions, 
            returns the value of the unpaired element.
    
            EXAMPLE
                A[0] = 9  A[1] = 3  A[2] = 9
                A[3] = 3  A[4] = 9  A[5] = 7
                A[6] = 9
                the function should return 7
    
            RULE:
                N is an odd integer within the range [1..1,000,000];
                each element of array A is an integer within the range [1..1,000,000,000];
                all but one of the values in A occur an even number of times.
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Odd Occurrences In Array!");
            long[] array = new long[5];
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(Console.ReadLine());
            }
            long result = OddOccurrences(array);
            Console.WriteLine("Output: [{0}]", string.Join(", ", result));
            Console.ReadKey();
        }

        private static long OddOccurrences(long[] A)
        {
            long[] copyAItems = new long[A.Length];
            A.CopyTo(copyAItems, 0);
            long previousItem = -1;
            for (long i = 0; i < A.Length; i++)
            {
                for (long y = 0; y < A.Length; y++)
                {
                    if (A[i] == A[y])
                    {
                        if (previousItem != -1)
                        {
                            copyAItems[y] = -1;
                            copyAItems[previousItem] = -1;
                        }
                        previousItem = i;
                    }
                }
                previousItem = -1;
            }
            long result = 0;
            for (long c = 0; c < copyAItems.Length; c++)
            {
                if (copyAItems[c] != -1)
                {
                    result = copyAItems[c];
                }
            }
            return result;
        }
    }
}
