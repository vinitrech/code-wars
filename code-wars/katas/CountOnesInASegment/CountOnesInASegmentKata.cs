using System.Numerics;

namespace katas.CountOnesInASegment;

public class CountOnesInASegmentKata
{
    public static BigInteger CountOnes(long left, long right)
    {
        if (left > right) return 0;

        return CountOnesUpTo(right) - CountOnesUpTo(left - 1);
    }

    private static long CountOnesUpTo(long n)
    {
        var total = 0L;

        while (n > 0)
        {
            var p = 1L;
            var k = 0;

            while ((p << 1) <= n)
            {
                p <<= 1;
                k++;
            }

            total += k * (p >> 1);
            total += n - p + 1;
            n -= p;
        }

        return total;
    }
}
