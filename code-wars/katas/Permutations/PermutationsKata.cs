namespace katas.Permutations;

public class PermutationsKata
{
    public static List<string> SinglePermutations(string s) =>
        [.. s.Aggregate(new List<string> { "" }, (acc, c) => [.. acc.SelectMany(a => Enumerable.Range(0, a.Length + 1).Select(i => a.Insert(i, c.ToString())))]).Distinct()];
}