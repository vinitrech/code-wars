using System.Numerics;

namespace katas.AddingBigNumbers;

public class AddingBigNumbersKata
{
    public static string Add(string a, string b) => $"{BigInteger.Parse(a) + BigInteger.Parse(b)}";
}
