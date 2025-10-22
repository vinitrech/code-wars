using FluentAssertions;
using katas.BreadcrumbGenerator;

namespace kata.tests.UnitTests;

public class BreadcrumbGeneratorKataTests
{
    [Theory]
    [InlineData("mysite.com/pictures/holidays.html", " : ", "<a href=\"/\">HOME</a> : <a href=\"/pictures/\">PICTURES</a> : <span class=\"active\">HOLIDAYS</span>")]
    [InlineData("www.codewars.com/users/GiacomoSorbi?ref=CodeWars", " / ", "<a href=\"/\">HOME</a> / <a href=\"/users/\">USERS</a> / <span class=\"active\">GIACOMOSORBI</span>")]
    [InlineData("www.microsoft.com/docs/index.htm#top", " * ", "<a href=\"/\">HOME</a> * <span class=\"active\">DOCS</span>")]
    [InlineData("mysite.com/very-long-url-to-make-a-silly-yet-meaningful-example/example.asp", " > ", "<a href=\"/\">HOME</a> > <a href=\"/very-long-url-to-make-a-silly-yet-meaningful-example/\">VLUMSYME</a> > <span class=\"active\">EXAMPLE</span>")]
    [InlineData("https://www.linkedin.com/in/giacomosorbi", " * ", "<a href=\"/\">HOME</a> * <a href=\"/in/\">IN</a> * <span class=\"active\">GIACOMOSORBI</span>")]
    [InlineData("www.agcpartners.co.uk", " # ", "<span class=\"active\">HOME</span>")]
    [InlineData("https://www.agcpartners.co.uk/index.html", " >>> ", "<span class=\"active\">HOME</span>")]
    [InlineData("http://www.agcpartners.co.uk", " % ", "<span class=\"active\">HOME</span>")]
    [InlineData("www.agcpartners.co.uk/", " * ", "<span class=\"active\">HOME</span>")]
    [InlineData("www.very-long-site_name-to-make-a-silly-yet-meaningful-example.com/users/giacomo-sorbi", " + ", "<a href=\"/\">HOME</a> + <a href=\"/users/\">USERS</a> + <span class=\"active\">GIACOMO SORBI</span>")]
    public void On_Success_Should_Validate_BreadcrumbGeneratorKata(string url, string separator, string expectedBreadcrumb)
    {
        BreadcrumbGeneratorKata.GenerateBC(url, separator).Should().Be(expectedBreadcrumb);
    }
}
