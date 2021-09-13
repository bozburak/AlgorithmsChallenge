using Abstracts;
using Factory;

namespace Main
{
    class Program
    {
        static void Main()
        {
            IAlgorithm algroithm = AlgorithmFactory.GetAlgorithm("Concretes.BinaryGap");
            algroithm.Algroithm();
        }
    }
}
