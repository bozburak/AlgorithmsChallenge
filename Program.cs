using Abstracts;
using Factory;

namespace Main
{
    class Program
    {
        static void Main()
        {
            IAlgorithm algroithm = AlgorithmFactory.GetAlgorithm("PassingCars");
            algroithm.Algroithm();
        }
    }
}
