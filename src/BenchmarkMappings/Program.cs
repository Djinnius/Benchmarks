using BenchmarkDotNet.Running;
using System;

namespace BenchmarkMappings
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MappingBenchmarks>();
        }
    }
}
