namespace katas.GreedIsGood;

public class GreedIsGoodKata
{
    public static int Score(int[] dice) => dice.CountBy(value => value).Sum(GetScore);

    private static int GetScore(KeyValuePair<int, int> pair) =>
        pair switch
        {
            { Key: 1 } => pair.Value >= 3 ? 1000 * (pair.Value / 3) + (pair.Value % 3 * 100) : pair.Value * 100,
            { Key: 2 } => pair.Value >= 3 ? 200 * (pair.Value / 3) : 0,
            { Key: 3 } => pair.Value >= 3 ? 300 * (pair.Value / 3) : 0,
            { Key: 4 } => pair.Value >= 3 ? 400 * (pair.Value / 3) : 0,
            { Key: 5 } => pair.Value >= 3 ? 500 * (pair.Value / 3) + (pair.Value % 3 * 50) : pair.Value * 50,
            { Key: 6 } => pair.Value >= 3 ? 600 * (pair.Value / 3) : 0,
            _ => 0
        };
}
