using BenchmarkDotNet.Running;

namespace kata.benchmark;

public class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<DetectPangramKataBenchmarks>();
    }
}
