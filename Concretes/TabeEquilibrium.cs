using System;
using Abstracts;

namespace Concretes
{
    public class TabeEquilibrium : IAlgorithm
    {
        /*
        A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.

        Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].

        The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
    
            EXAMPLE
                A[0] = 3
                A[1] = 1
                A[2] = 2
                A[3] = 4
                A[4] = 3

                P = 1, difference = |3 − 10| = 7
                P = 2, difference = |4 − 9| = 5
                P = 3, difference = |6 − 7| = 1
                P = 4, difference = |10 − 3| = 7
    
            RULE:
                N is an integer within the range [2..100,000];
                each element of array A is an integer within the range [−1,000..1,000].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("TabeEquilibrium!");
            long[] array = new long[5];
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(Console.ReadLine());
            }
            long result = FindMinimalDifference(array);
            Console.WriteLine($"Output: {result}");
            Console.ReadKey();
        }

        private static long FindMinimalDifference(long[] A)
        {
            long p = A.Length;
            long minDiff = -1;
            for (long i = 1; i < p; i++)
            {
                long sumRight = 0;
                long sumLeft = 0;
                for (int f = 0; f < A.Length; f++)
                {
                    if (f < i)
                    {
                        sumLeft += A[f];
                    }
                    else
                    {
                        sumRight += A[f];
                    }
                }
                long total = Math.Abs(sumLeft - sumRight);
                if (minDiff == -1 || total < minDiff)
                {
                    minDiff = total;
                }
            }
            return minDiff;
        }
    }
}
