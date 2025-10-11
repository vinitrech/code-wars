namespace katas.DetectPangram;

public class DetectPangramKata
{
    public static bool IsPangram(string str) => str.ToLower().Where(char.IsLetter).Distinct().Count() == 26;

    public static bool IsPangramHashset(string str) => new HashSet<char>(str.ToLower().Where(char.IsLetter)).Count == 26;
}
