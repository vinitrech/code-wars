namespace katas.MovingZerosToTheEnd;

public class MovingZerosToTheEndKata
{
    public static int[] MoveZeroes(int[] arr) => [.. arr.GroupBy(x => x == 0).OrderBy(x => x.Key is true ? 0 : 1).SelectMany(g => g)];
}
