using System;
using Abstracts;

namespace Concretes
{
    public class FrogRiverOne : IAlgorithm
    {
        /*
            The goal is to find the earliest time when the frog can jump to the other side of the river. 
            The frog can cross only when leaves appear at every position across the river from 1 to X 
            (that is, we want to find the earliest moment when all the positions from 1 to X are covered 
            by leaves). You may assume that the speed of the current in the river is negligibly small, i.e. 
            the leaves do not change their positions once they fall in the river.
    
            EXAMPLE
                A[0] = 1
                A[1] = 3
                A[2] = 1
                A[3] = 4
                A[4] = 2
                A[5] = 3
                A[6] = 5
                A[7] = 4

                return 6;
    
            RULE:
                N and X are integers within the range [1..100,000];
                each element of array A is an integer within the range [1..X].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("FrogRiverOne!");
            int[] array = new int[8];
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("goal!");
            int x = Convert.ToInt32(Console.ReadLine());
            long result = FindEarliestTime(array, x);
            Console.WriteLine($"Output: {result}");
            Console.ReadKey();
        }

        private static long FindEarliestTime(int[] A, int X)
        {

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    return i;
                }
            }

            // HashSet<long> hs = new();
            // for (int i = 1; i <= 5; i++)
            // {
            //     hs.Add(i);
            // }

            // for (int i = 0; i < A.Length; i++)
            // {
            //     if (hs.Remove(A[i]))
            //     {
            //         if (hs.Count == 0)
            //         {
            //             return item;
            //         }
            //     }
            // }

            return -1;
        }
    }
}
