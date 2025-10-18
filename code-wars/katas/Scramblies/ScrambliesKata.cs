namespace katas.Scramblies;

public class ScrambliesKata
{
    public static bool Scramble(string str1, string str2) => str2.CountBy(character => character).All(characterCount => str1.Count(characterCount.Key) >= characterCount.Value);
}
