using BenchmarkDotNet.Running;
using System;

namespace dotnet_core
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Iteration>();
            Console.Read();
        }
    }
}
