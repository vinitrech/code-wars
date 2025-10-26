using FluentAssertions;
using katas.Connect4;

namespace kata.tests.UnitTests;

public class Connect4KataTests
{
    [Fact]
    public void On_Success_Should_Return_Player_1_Wins()
    {
        var connect4Kata = new Connect4Kata();
        var moves = new int[] { 0, 0, 0, 1, 0, 1, 0, 1, 0 };
        var result = string.Empty;

        foreach (var move in moves)
            result = connect4Kata.Play(move);

        result.Should().Be("Player 1 wins!");
    }

    [Fact]
    public void On_Success_Should_Return_Game_Has_Finished()
    {
        var connect4Kata = new Connect4Kata();
        var moves = new int[] { 1, 1, 2, 2, 3, 3, 4, 4 };
        var result = string.Empty;

        foreach (var move in moves)
            result = connect4Kata.Play(move);

        result.Should().Be("Game has finished!");
    }
}
