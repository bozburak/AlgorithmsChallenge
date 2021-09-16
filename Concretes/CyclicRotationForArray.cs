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
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int key = Convert.ToInt32(Console.ReadLine());
            int[] result = CyclicRotation(array, key);
            Console.WriteLine("Output: [{0}]", string.Join(", ", result));
            Console.ReadKey();
        }

        private static int[] CyclicRotation(int[] A, int K)
        {
            int i = 1;
            while (K >= i)
            {
                int[] copyAItems = new int[A.Length];
                A.CopyTo(copyAItems, 0);
                int lastItem = A[^1];
                for (int f = 0; f < A.Length; f++)
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
