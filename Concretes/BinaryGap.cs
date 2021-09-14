using System;
using System.Collections.Generic;
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

        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Binary Gap!");
            Console.ReadLine();
            List<int> result = CalculateGapOfLength(20);
            StringBuilder resultString = new();
            foreach (int item in result)
            {
                Console.WriteLine();
                resultString.AppendLine($"One of Length {item}.");
            }
            Console.WriteLine(resultString.ToString());
            Console.ReadKey();
        }

        private static List<int> CalculateGapOfLength(int N)
        {
            string binaryN = Convert.ToString(N, 2).ToString();
            List<int> allCountOfZero = new();
            int countOfZero = 0;
            for (int i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[i] == '0')
                {
                    countOfZero++;
                }
                else if (countOfZero != 0)
                {
                    allCountOfZero.Add(countOfZero);
                    countOfZero = 0;
                }
            }
            return allCountOfZero;
        }
    }
}
