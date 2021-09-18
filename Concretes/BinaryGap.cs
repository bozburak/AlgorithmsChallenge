using System;
using System.Text;
using Abstracts;

namespace Concretes
{
    public class BinaryGap : IAlgorithm
    {
        /*
            A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is 
            surrounded by ones at both ends in the binary representation of N.

            EXAMPLE

            input: 9
            9 binary representation: 1001
            binary gap: 2 length

            RULE:
            N is an integer within the range [1..2,147,483,647].
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Binary Gap!");
            string n = Console.ReadLine();
            long[] result = CalculateGapOfLength(Convert.ToInt64(n));
            StringBuilder resultString = new();
            foreach (long item in result)
            {
                if (item != 0)
                {
                    Console.WriteLine();
                    resultString.AppendLine($"One of Length {item}.");
                }
            }
            Console.WriteLine(resultString.ToString());
            Console.ReadKey();
        }

        private static long[] CalculateGapOfLength(long N)
        {
            string binaryN = Convert.ToString(N, 2).ToString();
            long[] allCountOfZero = new long[binaryN.Length];
            long countOfZero = 0;
            long arrayItemIndex = 0;
            for (long i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[Convert.ToInt32(i)] == '0')
                {
                    countOfZero++;
                }
                else if (countOfZero != 0)
                {
                    allCountOfZero[arrayItemIndex] = countOfZero;
                    countOfZero = 0;
                    arrayItemIndex++;
                }
            }
            return allCountOfZero;
        }
    }
}
