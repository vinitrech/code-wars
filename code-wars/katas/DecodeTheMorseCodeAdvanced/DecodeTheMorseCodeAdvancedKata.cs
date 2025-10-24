using System.Text.RegularExpressions;

namespace katas.DecodeTheMorseCodeAdvanced;

public class DecodeTheMorseCodeAdvancedKata
{
    public static string DecodeBits(string bits)
    {
        var trimmedBits = bits.Trim('0');

        if (string.IsNullOrWhiteSpace(trimmedBits))
            return string.Empty;

        var groups = Regex.Matches(trimmedBits, "(0+|1+)", options: RegexOptions.Compiled, matchTimeout: TimeSpan.FromMilliseconds(500)).Select(match => match.Value).ToList();
        var timeUnit = groups.Min(group => group.Length);
        var normalizedBits = groups.Select(group => new { Bit = group[0], Units = group.Length / timeUnit }).ToList();
        var morse = "";

        for (var index = 0; index < normalizedBits.Count; index++)
        {
            var group = normalizedBits[index];

            if (group.Bit == '1')
            {
                if (group.Units == 1)
                    morse += ".";
                else if (group.Units >= 3)
                    morse += "-";
            }
            else
            {
                if (group.Units == 3)
                    morse += " ";
                else if (group.Units == 7)
                    morse += "   ";
            }
        }

        return morse;
    }

    public static string DecodeMorse(string morseCode)
    {
        var morseDictionary = SetupMorseDictionary();
        var encodedWords = morseCode.Split("   ");
        var decodedWords = encodedWords.Select(encodedWord => DecodeWord(morseDictionary, encodedWord));

        return string.Join(" ", decodedWords).Trim();
    }

    private static string DecodeWord(Dictionary<string, string> morseDictionary, string encodedWord) =>
        string.Join("", DecodeSymbols(morseDictionary, encodedWord));

    private static IEnumerable<string> DecodeSymbols(Dictionary<string, string> morseDictionary, string encodedWord) =>
        encodedWord.Split(" ").Where(symbol => !string.IsNullOrWhiteSpace(symbol)).Select(symbol => morseDictionary[symbol]);

    private static Dictionary<string, string> SetupMorseDictionary() => new()
    {
        // Letters
        { ".-", "A" },    { "-...", "B" },  { "-.-.", "C" },  { "-..", "D" },
        { ".", "E" },     { "..-.", "F" },  { "--.", "G" },   { "....", "H" },
        { "..", "I" },    { ".---", "J" },  { "-.-", "K" },   { ".-..", "L" },
        { "--", "M" },    { "-.", "N" },    { "---", "O" },   { ".--.", "P" },
        { "--.-", "Q" },  { ".-.", "R" },   { "...", "S" },   { "-", "T" },
        { "..-", "U" },   { "...-", "V" },  { ".--", "W" },   { "-..-", "X" },
        { "-.--", "Y" },  { "--..", "Z" },

        // Numbers
        { ".----", "1" }, { "..---", "2" }, { "...--", "3" }, { "....-", "4" },
        { ".....", "5" }, { "-....", "6" }, { "--...", "7" }, { "---..", "8" },
        { "----.", "9" }, { "-----", "0" },

        // Punctuation and prosigns
        { ".-.-.-", "." }, { "--..--", "," }, { "..--..", "?" }, { ".----.", "'" },
        { "-.-.--", "!" }, { "-..-.", "/" },  { "-.--.", "(" },  { "-.--.-", ")" },
        { ".-...", "&" },  { "---...", ":" }, { "-.-.-.", ";" }, { "-...-", "=" },
        { ".-.-.", "+" },  { "-....-", "-" }, { "..--.-", "_" }, { ".-..-.", "\"" },
        { "...-..-", "$" },{ ".--.-.", "@" },

        // Special prosigns
        { "...---...", "SOS" }
    };
}
