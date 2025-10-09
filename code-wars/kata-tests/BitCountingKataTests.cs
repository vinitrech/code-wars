using FluentAssertions;
using kata_solutions.BitCounting;

namespace stop_gninnips_my_sdrow_tests;

public class BitCountingKataTests
{
    [Theory]
    [InlineData(1234, 5)]
    public void On_Success_Should_Validate_BitCountingKata(int input, int expectedOutput)
    {
        BitCountingKata.CountBits(input).Should().Be(expectedOutput);
    }
}
