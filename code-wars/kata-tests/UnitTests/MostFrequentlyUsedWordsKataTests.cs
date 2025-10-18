using FluentAssertions;
using katas.MostFrequentlyUsedWords;

namespace kata.tests.UnitTests;

public class MostFrequentlyUsedWordsKataTests
{
    private const string InputText = "In a village of La Mancha, the name of which I have no desire to call to" +
                      "mind, there lived not long since one of those gentlemen that keep a lance" +
                      "in the lance-rack, an old buckler, a lean hack, and a greyhound for" +
                      "coursing. An olla of rather more beef than mutton, a salad on most" +
                      "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra" +
                      "on Sundays, made away with three-quarters of his income.";

    [Theory]
    [InlineData("a a a  b  c c  d d d d  e e e e e", new string[] { "e", "d", "a" })]
    [InlineData("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e", new string[] { "e", "ddd", "aa" })]
    [InlineData("  //wont won't won't ", new string[] { "won't", "wont" })]
    [InlineData("  , e   .. ", new string[] { "e" })]
    [InlineData("  ...  ", new string[] { })]
    [InlineData("  '  ", new string[] { })]
    [InlineData("  '''  ", new string[] { })]
    [InlineData(InputText, new string[] { "a", "of", "on" })]
    public void On_Success_Should_Validate_MostFrequentlyUsedWordsKata(string inputText, string[] expectedTop3)
    {
        MostFrequentlyUsedWordsKata.Top3(inputText).Should().BeEquivalentTo(expectedTop3);
    }
}
