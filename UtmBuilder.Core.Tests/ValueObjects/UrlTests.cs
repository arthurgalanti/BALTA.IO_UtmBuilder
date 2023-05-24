using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    [TestMethod]
    public void DadoUmaUrlInvalidaDeveRetornaUmaException_TryCatch()
    {
        try
        {
            var url = new Url("galanti.dev");
            Assert.Fail();
        }
        catch (InvalidUrlException e)
        {
            Assert.IsTrue(true);
        }
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void DadoUmaUrlInvalidaDeveRetornaUmaException_ExpextedException()
    {
        var url = new Url("galanti.dev");
    }
    
    [TestMethod]
    public void DadoUmaUrlValidaNaoDeveRetornaUmaException()
    {
        var url = new Url("https://balta.io");
        Assert.IsTrue(true);
    }
}