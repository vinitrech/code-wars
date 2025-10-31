namespace katas.CountingChangeCombinations;

public class CountingChangeCombinationsKata
{
    public static int CountCombinations(int money, int[] coins)
    {
        var ways = new int[money + 1];

        ways[0] = 1;

        foreach (var coin in coins)
            for (int i = coin; i <= money; i++)
                ways[i] += ways[i - coin];

        return ways[money];
    }
}
