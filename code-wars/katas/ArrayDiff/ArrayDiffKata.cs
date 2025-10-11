namespace katas.ArrayDiff;

public class ArrayDiffKata
{
    public static int[] ArrayDiff(int[] a, int[] b) => [.. a.Where(x => !b.Contains(x))];

    public static int[] ArrayDiffDictionary(int[] a, int[] b)
    {
        var dict = b.Distinct().ToDictionary(x => x);

        return [.. a.Where(x => !dict.ContainsKey(x))];
    }

    public static int[] ArrayDiffFor(int[] a, int[] b)
    {
        var finalArray = Array.Empty<int>();

        for (var index = 0; index < a.Length; index++)
        {
            for (var innerIndex = 0; innerIndex < b.Length; innerIndex++)
                if (a[index] == b[innerIndex])
                    continue;

            finalArray = [.. finalArray, a[index]];
        }

        return finalArray;
    }

    public static int[] ArrayDiffHashSet(int[] a, int[] b)
    {
        var hashSetB = new HashSet<int>(b);

        return [.. a.Where(x => !hashSetB.Contains(x))];
    }
}
