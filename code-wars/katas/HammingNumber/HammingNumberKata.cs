namespace katas.HammingNumber;

public class HammingNumberKata
{
    public static long Hamming(int n)
    {
        var sequence = new List<long>() { 1 };
        var (i2, i3, i5) = (0, 0, 0);

        while (sequence.Count < n)
        {
            var (next2, next3, next5) = (sequence[i2] * 2, sequence[i3] * 3, sequence[i5] * 5);
            var nextValue = new List<long> { next2, next3, next5 }.Min();

            sequence.Add(nextValue);

            if (nextValue == next2)
                i2 += 1;
            if (nextValue == next3)
                i3 += 1;
            if (nextValue == next5)
                i5 += 1;
        }

        return sequence[n - 1];
    }
}
