using System;
using Abstracts;

namespace Concretes
{
    public class CyclicRotationForArray : IAlgorithm
    {
        /*
            The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.
    
            EXAMPLE
    
            input: Array: [3, 8, 9, 7, 6], RotationKey: 1
            output: [6, 3, 8, 9, 7] 
    
            RULE:
            
            N and K are integers within the range [0..100];
            each element of array A is an integer within the range [0..1,000].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Cyclic Rotation!");
            long[] array = new long[5];
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(Console.ReadLine());
            }
            long key = Convert.ToInt64(Console.ReadLine());
            long[] result = CyclicRotation(array, key);
            Console.WriteLine("Output: [{0}]", string.Join(", ", result));
            Console.ReadKey();
        }

        private static long[] CyclicRotation(long[] A, long K)
        {
            long i = 1;
            while (K >= i)
            {
                long[] copyAItems = new long[A.Length];
                A.CopyTo(copyAItems, 0);
                long lastItem = A[^1];
                for (long f = 0; f < A.Length; f++)
                {
                    if (A.Length <= f + 1)
                    {
                        A[0] = lastItem;
                        break;
                    }
                    A[f + 1] = copyAItems[f];
                }
                i++;
            }
            return A;
        }
    }
}
