namespace katas.GreedIsGood;

public class GreedIsGoodKata
{
    public static int Score(int[] dice) => dice.CountBy(value => value).Sum(GetScore);

    private static int GetScore(KeyValuePair<int, int> pair) =>
        pair switch
        {
            { Key: 1, Value: 3 } => 1000,
            { Key: 6, Value: 3 } => 600,
            { Key: 5, Value: 3 } => 500,
            { Key: 4, Value: 3 } => 400,
            { Key: 3, Value: 3 } => 300,
            { Key: 2, Value: 3 } => 200,
            { Key: 1, Value: 1 } => 100,
            { Key: 5, Value: 1 } => 50,
            { Key: 1 } => pair.Value * 100,
            { Key: 5 } => pair.Value * 50,
            _ => 0
        };
}
