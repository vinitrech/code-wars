using FluentAssertions;
using katas.HeadTailInitAndLast;

namespace kata.tests.UnitTests;

public class HeadTailInitAndLastKataTests
{
    [Fact]
    public void On_Success_Should_Validate_Head()
    {
        HeadTailInitAndLastKata.Head(list: [5, 1]).Should().Be(5);
    }

    [Fact]
    public void On_Success_Should_Validate_Tail()
    {
        HeadTailInitAndLastKata.Tail(list: [1, 2, 3]).Should().BeEquivalentTo([2, 3]);
    }

    [Fact]
    public void On_Success_Should_Validate_Init()
    {
        HeadTailInitAndLastKata.Init(list: [1, 5, 7, 9]).Should().BeEquivalentTo([1, 5, 7]);
    }

    [Fact]
    public void On_Success_Should_Validate_Last()
    {
        HeadTailInitAndLastKata.Last_(list: [7, 2]).Should().Be(2);
    }
}
