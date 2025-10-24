using FluentAssertions;
using katas.AddingBigNumbers;

namespace kata.tests.UnitTests;

public class AddingBigNumbersKataTests
{
    [Theory]
    //[InlineData("12345678901234567890", "98765432109876543210", "111111111011111111100")]
    //[InlineData("91", "19", "110")]
    //[InlineData("123456789", "987654322", "1111111111")]
    //[InlineData("999999999", "1", "1000000000")]
    [InlineData("823094582094385190384102934810293481029348123094818923749817", "234758927345982475298347523984572983472398457293847594193837", "1000000000")]
    public void On_Success_Should_Validate_AddingBigNumbersKata(string a, string b, string expectedSum)
    {
        AddingBigNumbersKata.Add(a, b).Should().Be(expectedSum);
    }
}
