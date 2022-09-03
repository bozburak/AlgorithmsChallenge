using System;
using Abstracts;

namespace Concretes
{
    public class FrogJmp : IAlgorithm
    {
        /*
            Given three integers X, Y and D, returns the minimal number of jumps from position X to a position equal to or greater than Y.

            EXAMPLE:
                X = 20
                Y = 170
                D = 60

                first jump 80 + 60 = 80
                second jump 140 + 60 = 140
                third jump 200 + 60 = 200

            RULE:            
                X, Y and D are integers within the range [1..1,000,000,000]
                X ≤ Y
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Stepping Jump! Write X then Y then D");
            long x = Convert.ToInt64(Console.ReadLine());
            long y = Convert.ToInt64(Console.ReadLine());
            long d = Convert.ToInt64(Console.ReadLine());
            string result = Stepping(x, y, d);
            Console.WriteLine($"Output:{Environment.NewLine}{result}");
            Console.ReadKey();
        }

        private static string Stepping(long x, long y, long d)
        {
            string result = string.Empty;

            while (y > x)
            {
                x += d;
                result += $"{x} + {d} = {x} {Environment.NewLine}";
            }

            return result;
        }
    }
}
