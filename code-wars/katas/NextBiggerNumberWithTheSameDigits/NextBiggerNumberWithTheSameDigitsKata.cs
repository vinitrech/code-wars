namespace katas.NextBiggerNumberWithTheSameDigits;

public class NextBiggerNumberWithTheSameDigitsKata
{
    public static long NextBiggerNumber(long n)
    {
        var digits = n.ToString().ToCharArray();

        for (var i = digits.Length - 1; i > 0; i--)
            if (digits[i] > digits[i - 1])
            {
                var pivot = i - 1;
                var suffix = digits[i..];
                var minGreaterAfterPivot = (Value: suffix[0], Index: 0);

                for (var suffixIndex = 0; suffixIndex < suffix.Length; suffixIndex++)
                    minGreaterAfterPivot = suffix[suffixIndex] > digits[pivot] && suffix[suffixIndex] < minGreaterAfterPivot.Value ? (suffix[suffixIndex], suffixIndex) : minGreaterAfterPivot;

                (digits[pivot], digits[minGreaterAfterPivot.Index + i]) = (digits[minGreaterAfterPivot.Index + i], digits[pivot]);

                digits.AsSpan()[i..].Sort();

                return long.Parse(new string(digits));
            }

        return -1;
    }
}
