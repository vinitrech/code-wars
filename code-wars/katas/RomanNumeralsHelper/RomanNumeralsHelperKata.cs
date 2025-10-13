using System.Text;

namespace katas.RomanNumeralsHelper;

public class RomanNumeralsHelperKata
{
    public static string ToRoman(int n)
    {
        var romanNumberBuilder = new StringBuilder();
        var romanNumbers = SetupValueByRomanNumberDictionary();

        while (n > 0)
        {
            var romanNumber = romanNumbers.First(romanNumber => n >= romanNumber.Value);

            romanNumberBuilder.Append(romanNumber.Key);
            n -= romanNumber.Value;
        }

        return romanNumberBuilder.ToString();
    }

    public static int FromRoman(string romanNumeral)
    {
        var sum = 0;
        var romanNumbers = SetupValueByRomanNumberDictionary();

        while (romanNumeral.Length > 0)
        {
            var match = romanNumbers.Keys.First(romanNumeral.StartsWith);

            sum += romanNumbers[match];
            romanNumeral = romanNumeral[match.Length..];
        }

        return sum;
    }

    private static Dictionary<string, int> SetupValueByRomanNumberDictionary() => new()
    {
        ["M"] = 1000,
        ["CM"] = 900,
        ["D"] = 500,
        ["CD"] = 400,
        ["C"] = 100,
        ["XC"] = 90,
        ["L"] = 50,
        ["XL"] = 40,
        ["X"] = 10,
        ["IX"] = 9,
        ["V"] = 5,
        ["IV"] = 4,
        ["I"] = 1
    };
}
