namespace SumOfTwoLowestPositiveIntegers;

public static class SumOfTwoLowestPositiveIntegersKata
{
    public static int SumTwoSmallestNumbers(int[] numbers) => numbers.Order().Take(2).Sum();
}
