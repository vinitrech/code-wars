namespace katas.MeanSquareError;

public class MeanSquareErrorKata
{
    public static double Solution(int[] firstArray, int[] secondArray) => firstArray.Zip(secondArray, (first, second) => Math.Pow(Math.Abs(first - second), 2)).Average();
}
