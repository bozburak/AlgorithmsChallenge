using System;
using System.Collections.Generic;
using Abstracts;

namespace Concretes
{
    public class MissingInteger : IAlgorithm
    {
        /*
            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

            EXAMPLE

            given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            given A = [1, 2, 3], the function should return 4.
            given A = [−1, −3], the function should return 1.

            RULE:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Missing Integer!");
            int result = Solution(new int[6] { 1, 3, 6, 4, 1, 2 });
            int resultA = Solution(new int[3] { 1, 2, 3 });
            int resultB = Solution(new int[2] { -1, -3 });
            Console.ReadKey();
        }

        private static int Solution(int[] A)
        {
            int result = 1;
            SortedSet<int> ts = new SortedSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                ts.Add(A[i]);
            }

            for (int i = 0; i <= ts.Count; i++)
            {
                int value = -1;
                if (ts.TryGetValue(i, out value))
                {
                    if (value > 0)
                    {
                        if (result == value)
                        {
                            result++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
