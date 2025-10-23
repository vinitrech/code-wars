namespace katas.DecodeTheMorseCodeAdvanced;

//INCOMPLETE - NOT WORKING PROPERLY
public class DecodeTheMorseCodeAdvancedKata
{
    public static string DecodeBits(string bits) =>
        string.Join("   ", bits.Split("00000000")
                .Select(part =>
                {
                    var translatedCharacters = part.Split("0000")
                        .Where(part => !string.IsNullOrWhiteSpace(part))
                        .Select(word =>
                        {
                            return string.Join("", word.Split("00")
                                .Where(character => !string.IsNullOrWhiteSpace(character))
                                .Select(character => character switch
                                {
                                    "11" => ".",
                                    "111111" => "-",
                                    _ => ""
                                }));
                        });

                    return string.Join(" ", translatedCharacters);
                })
            );

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
