using System.Data;

namespace katas.DecodeTheMorseCode;

public class DecodeTheMorseCodeKata
{
    public static string Decode(string morseCode)
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
