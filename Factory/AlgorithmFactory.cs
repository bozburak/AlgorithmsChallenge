using System;
using System.Reflection;
using Abstracts;

namespace Factory
{
    public static class AlgorithmFactory
    {
        public static IAlgorithm GetAlgorithm(string algorithmName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string type = assembly.GetType("Concretes." + algorithmName).FullName;
            return (IAlgorithm)Activator.CreateInstanceFrom(assembly.Location, type).Unwrap();
        }
    }
}