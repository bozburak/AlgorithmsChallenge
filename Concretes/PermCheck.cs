using System;
using System.Collections.Generic;
using Abstracts;

namespace Concretes
{
    public class PermCheck : IAlgorithm
    {
        /*
        A non-empty array A consisting of N integers is given.

        A permutation is a sequence containing each element from 1 to N once, and only once
    
            EXAMPLE
                A[0] = 4
                A[1] = 1
                A[2] = 3
                A[3] = 2

                return 0. - returns 1 if array A is a permutation and 0 if it is not.

            RULE:
                N is an integer within the range [1..100,000];
                each element of array A is an integer within the range [1..1,000,000,000].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("PermCheck!");
            long[] array = new long[5];
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(Console.ReadLine());
            }
            long result = CheckPerm(array, array.Length);
            Console.WriteLine($"Output: {result}");
            Console.ReadKey();
        }

        private static int CheckPerm(long[] A, int N)
        {
            HashSet<long> hs = new();

            for (long i = 0; i < N; i++)
            {
                hs.Add(A[i]);
            }

            if (hs.Count == N)
            {
                return 1;
            }

            return 0;
        }
    }
}
