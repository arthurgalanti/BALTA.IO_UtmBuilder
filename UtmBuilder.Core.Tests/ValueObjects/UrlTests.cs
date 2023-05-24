using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string UrlInvalida = "galanti.dev";
    private const string UrlValida = "https://galanti.dev";
    
    [TestMethod]
    public void DadoUmaUrlInvalidaDeveRetornarUmaException_TryCatch()
    {
        try
        {
            var url = new Url(UrlInvalida);
            Assert.Fail();
        }
        catch (InvalidUrlException)
        {
            Assert.IsTrue(true);
        }
    }
    
    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void DadoUmaUrlInvalidaDeveRetornarUmaException_ExpextedException()
    {
        var url = new Url(UrlInvalida);
    }
    
    [TestMethod]
    public void DadoUmaUrlValidaNaoDeveRetornarUmaException()
    {
        var url = new Url(UrlValida);
        Assert.IsTrue(true);
    }
    
    [TestMethod]
    [DataRow(" ",true)]
    [DataRow("google",true)]
    [DataRow("http",true)]
    [DataRow(UrlValida,false)]
    public void DadoUmaListaDeUrlsDeveRetornarOuNaoUmaException_DataRow(string link, bool exceptionEsperada)
    {
        if (!exceptionEsperada)
        {
            var url = new Url(link);
            Assert.IsTrue(true);
        }
        else
        {
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
}