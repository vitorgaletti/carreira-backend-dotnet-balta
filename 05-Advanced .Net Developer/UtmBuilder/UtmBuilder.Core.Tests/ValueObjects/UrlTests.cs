using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "banana";
    private const string ValidUrl = "https://balta.io";

    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        var url = new Url(InvalidUrl);
    }

    [TestMethod]
    [DataRow(" ", true)]
    [DataRow("http", true)]
    [DataRow("banana", true)]
    [DataRow("https://balta.io", false)]
    public void TestUrl(string link, bool expectException)
    {
        if (!expectException) return;
        
        try
        {
            var url = new Url(link);
            Assert.Fail();
        }
        catch (InvalidUrlException)
        {
            Assert.IsTrue(true);
        }
    }
}