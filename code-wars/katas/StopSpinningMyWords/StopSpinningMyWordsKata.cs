namespace kata_solutions.StopSpinningMyWords;

public static class StopSpinningMyWordsKata
{
    public static string SpinWords(string sentence) => string.Join(" ", sentence.Split(' ').Select(w => w.Length > 4 ? string.Concat(w.Reverse()) : w));
}
