namespace katas.GreedIsGood;

public class GreedIsGoodKata
{
    public static int Score(int[] dice) => dice.CountBy(value => value).Sum(GetScore);

    private static int GetScore(KeyValuePair<int, int> pair) =>
        pair switch
        {
            { Key: 1 } => 1000 * (pair.Value / 3) + (pair.Value % 3 * 100),
            { Key: 2 } => 200 * (pair.Value / 3),
            { Key: 3 } => 300 * (pair.Value / 3),
            { Key: 4 } => 400 * (pair.Value / 3),
            { Key: 5 } => 500 * (pair.Value / 3) + (pair.Value % 3 * 50),
            { Key: 6 } => 600 * (pair.Value / 3),
            _ => 0
        };
}
