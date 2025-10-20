namespace katas.TwiceLinear;

public class TwiceLinearKata
{
    public static int DblLinear(int n)
    {
        var sortedSet = new SortedSet<int>() { 1 };
        var elements = new List<int>();

        while (elements.Count <= n)
        {
            var current = sortedSet.Min;
            sortedSet.Remove(current);
            elements.Add(current);

            sortedSet.Add(2 * current + 1);
            sortedSet.Add(3 * current + 1);
        }

        return elements[n];
    }
}
