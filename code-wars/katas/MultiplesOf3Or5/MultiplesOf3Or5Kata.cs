namespace katas.MultiplesOf3Or5;

public class MultiplesOf3Or5Kata
{
    public static int Solution(int value) => value < 3 ? 0 : Enumerable.Range(1, value - 1).Where(v => v % 3 == 0 || v % 5 == 0).Sum();
}
