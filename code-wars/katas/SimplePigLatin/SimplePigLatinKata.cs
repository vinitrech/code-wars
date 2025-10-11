namespace katas.SimplePigLatin;

public class SimplePigLatinKata
{
    public static string PigIt(string str) => string.Join(" ", str.Split(' ').Select(word => word.Any(c => char.IsPunctuation(c)) ? word : $"{word[1..]}{word[0]}ay"));
}
