using BenchmarkDotNet.Running;
using System;

namespace TestComputationSpeedBetweenDifferentTypes
{
    class Program
    {
        static void Main()
        {
            _ = BenchmarkRunner.Run<AdditionSpeedTests>();
            _ = BenchmarkRunner.Run<MultiplicationSpeedTests>();
            //Console.ReadLine();
        }
    }
}
