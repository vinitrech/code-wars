namespace katas.Connect4;

public class Connect4Kata
{
    private static readonly int MaxColumnElements = 6;
    public List<List<int>> Grid = [[], [], [], [], [], [], []];
    private int Player = 1;
    private bool HasFinished = false;

    public string Play(int col)
    {
        if (HasFinished)
            return "Game has finished!";
        if (Grid[col].Count >= MaxColumnElements)
            return "Column full!";

        Grid[col].Add(Player);

        if (!HasWon())
        {
            var turn = Player;
            Player = Player == 1 ? 2 : 1;

            return $"Player {turn} has a turn";
        }

        HasFinished = true;

        return $"Player {Player} wins!";
    }

    private bool HasWon() => HasWonVertically() || HasWonHorizontally() || HasWonDiagonally();

    private bool HasWonVertically()
    {
        foreach (var column in Grid.Select(column => column))
        {
            var count = 0;

            for (var row = 0; row < column.Count; row++)
            {
                count = column[row] == Player ? count + 1 : 0;
                if (count >= 4) return true;
            }
        }

        return false;
    }

    private bool HasWonHorizontally()
    {
        for (var row = 0; row < 6; row++)
        {
            var count = 0;

            for (var column = 0; column < 7; column++)
            {
                count = Grid[column].ElementAtOrDefault(row) == Player ? count + 1 : 0;

                if (count >= 4) return true;
            }
        }

        return false;
    }

    private bool HasWonDiagonally()
    {
        for (var column = 0; column < Grid.Count; column++)
        {
            for (var row = 0; row < 3; row++)
            {
                if (Grid.ElementAtOrDefault(column)?.ElementAtOrDefault(row) == Player &&
                    Grid.ElementAtOrDefault(column + 1)?.ElementAtOrDefault(row + 1) == Player &&
                    Grid.ElementAtOrDefault(column + 2)?.ElementAtOrDefault(row + 2) == Player &&
                    Grid.ElementAtOrDefault(column + 3)?.ElementAtOrDefault(row + 3) == Player)
                    return true;

                if (Grid.ElementAtOrDefault(column)?.ElementAtOrDefault(row + 3) == Player &&
                    Grid.ElementAtOrDefault(column + 1)?.ElementAtOrDefault(row + 2) == Player &&
                    Grid.ElementAtOrDefault(column + 2)?.ElementAtOrDefault(row + 1) == Player &&
                    Grid.ElementAtOrDefault(column + 3)?.ElementAtOrDefault(row) == Player)
                    return true;
            }
        }

        return false;
    }
}
