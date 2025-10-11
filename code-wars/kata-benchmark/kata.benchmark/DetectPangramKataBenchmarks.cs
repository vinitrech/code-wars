using BenchmarkDotNet.Attributes;
using katas.DetectPangram;

namespace kata.benchmark;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 5, iterationCount: 10)]
public class DetectPangramKataBenchmarks
{
    private readonly string a = "The quick brown fox jumps over the lazy dog.";

    [Benchmark]
    public bool LinqVersion() => DetectPangramKata.IsPangram(a);

    [Benchmark]
    public bool DictionaryVersion() => DetectPangramKata.IsPangramHashset(a);
}
