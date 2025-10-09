namespace katas.BitCounting;

public static class BitCountingKata
{
    public static int CountBits(int n) => Convert.ToString(n, 2).Count(c => c.Equals('1'));
}
