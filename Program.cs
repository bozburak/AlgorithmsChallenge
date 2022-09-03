using Abstracts;
using Factory;

namespace Main
{
    internal class Program
    {
        private static void Main()
        {
            IAlgorithm algroithm = AlgorithmFactory.GetAlgorithm("OverlappingHours");
            algroithm.Algroithm();
        }
    }
}