using System;
using Abstracts;

namespace Concretes
{
    public class MaxCounters : IAlgorithm
    {
        /*
            You are given N counters, initially set to 0, and you have two possible operations on them:

            increase(X) − counter X is increased by 1,
            max counter − all counters are set to the maximum value of any counter.
            A non-empty array A of M integers is given. This array represents consecutive operations:

            if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
            if A[K] = N + 1 then operation K is max counter.

            EXAMPLE

            For example, given integer N = 5 and array A such that:

                A[0] = 3
                A[1] = 4
                A[2] = 4
                A[3] = 6
                A[4] = 1
                A[5] = 4
                A[6] = 4
        
            RESULT
                (3, 2, 2, 4, 2)

            RULE:
            N and M are integers within the range [1..100,000];
            each element of array A is an integer within the range [1..N + 1].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Max Counters!");
            int[] result = Solution(5, new int[7] { 3, 4, 4, 6, 1, 4, 4 });
            Console.ReadKey();
        }

        private static int[] Solution(int N, int[] A)
        {
            int last = 0;
            int[] result = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                int item = A[i];

                if (item >= 1 && item <= N)
                {
                    result[item -1] += 1;

                    if (result[item - 1] > last)
                    {
                        last = result[item - 1];
                    }
                }
                else if (item == (N + 1))
                {
                    for (int x = 0; x < N; x++)
                    {
                        result[x] = last;
                    }
                }
            }

            return result;
        }
    }
}
