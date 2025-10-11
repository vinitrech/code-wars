using BenchmarkDotNet.Attributes;
using katas.ArrayDiff;

namespace kata.benchmark;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 5, iterationCount: 10)]
public class ArrayDiffKataBenchmarks
{
    private readonly int[] a = [1, 2, 2, 3, 4, 5, 6];
    private readonly int[] b = [2, 5];

    [Benchmark]
    public int[] LinqVersion() => ArrayDiffKata.ArrayDiff(a, b);

    [Benchmark]
    public int[] DictionaryVersion() => ArrayDiffKata.ArrayDiffDictionary(a, b);

    [Benchmark]
    public int[] ForVersion() => ArrayDiffKata.ArrayDiffFor(a, b);

    [Benchmark]
    public int[] HashSetVersion() => ArrayDiffKata.ArrayDiffHashSet(a, b);
}
