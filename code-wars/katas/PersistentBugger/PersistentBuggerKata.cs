namespace katas.PersistentBugger;

public class PersistentBuggerKata
{
    public static int Persistence(long n) => n < 10 ? 0 : Persistence(MultiplyDigits(n)) + 1;

    public static long MultiplyDigits(long number)
    {
        var digits = new List<long>();

        while (number > 0)
        {
            digits.Add(number % 10);
            number /= 10;
        }

        return digits.Aggregate((origin, next) => origin * next);
    }
}
