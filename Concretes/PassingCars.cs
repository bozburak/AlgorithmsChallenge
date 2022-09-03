using System;
using System.Linq;
using Abstracts;

namespace Concretes
{
    public class PassingCars : IAlgorithm
    {
        /*
            A non-empty array A consisting of N integers is given. The consecutive elements of array A represent consecutive cars on a road.

            Array A contains only 0s and/or 1s:

            0 represents a car traveling east,
            1 represents a car traveling west.
            The goal is to count passing cars. We say that a pair of cars (P, Q), where 0 ≤ P < Q < N, is passing when P is traveling to the east and Q is traveling to the west.

            that, given a non-empty array A of N integers, returns the number of pairs of passing cars.

            The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.

            EXAMPLE:

            For example, consider array A such that:

            A[0] = 0
            A[1] = 1
            A[2] = 0
            A[3] = 1
            A[4] = 1
            
            We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).

            RULE:
            N is an integer within the range [1..100,000];
            each element of array A is an integer that can have one of the following values: 0, 1.
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Missing Integer!");
            int result = Solution(new int[5] { 0, 1, 0, 1, 1 });
            Console.ReadKey();
        }

        private static int Solution(int[] A)
        {
            int result = 0;
            int current = 0;

            while (A.Contains(0))
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == 0 && current == -1)
                    {
                        current = i;
                    }
                    else if (A[i] == 1 && current != -1)
                    {
                        result++;
                    }
                }
                A = A.Where((val, idx) => idx != current).ToArray();
                current = -1;
            }

            return result > 1000000000 ? -1 : result;
        }
    }
}
