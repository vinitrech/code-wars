using BenchmarkDotNet.Attributes;
using katas.LandPerimeter;

namespace kata.benchmark;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 5, iterationCount: 10)]
public class LandPerimeterKataBenchmarks
{
    private readonly string[] a = "OXOOOX OXOXOO XXOOOX OXXXOO OOXOOX OXOOOO OOXOOX OOXOOO OXOOOO OXOOXX".Split(" ");

    [Benchmark]
    public string RawVersion() => LandPerimeterKata.Calculate(a);

    [Benchmark]
    public string LinqVersion() => LandPerimeterKata.CalculateLinq(a);
}
