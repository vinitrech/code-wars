using BenchmarkDotNet.Running;

namespace kata.benchmark;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<ArrayDiffKataBenchmarks>();
    }
}
