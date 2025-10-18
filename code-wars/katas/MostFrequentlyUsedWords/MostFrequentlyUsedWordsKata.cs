using System.Text.RegularExpressions;

namespace katas.MostFrequentlyUsedWords;

public class MostFrequentlyUsedWordsKata
{
    public static List<string> Top3(string s) =>
        [.. Regex.Replace(s.ToLower(), @"(?i)(?<![a-z])[’']+|[^a-z’']+", " ", options: RegexOptions.Compiled, matchTimeout: TimeSpan.FromMilliseconds(500))
            .Split(" ").Where(s => !string.IsNullOrWhiteSpace(s)).CountBy(word => word).OrderByDescending(c => c.Value).Take(3).Select(w => w.Key)];

}
