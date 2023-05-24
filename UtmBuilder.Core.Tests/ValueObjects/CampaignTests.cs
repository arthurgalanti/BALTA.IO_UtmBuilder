using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class CampaignTests
{
    [TestMethod]
    [DataRow("source", "medium", "campaign", false)]
    [DataRow("source", "medium", "", true)]
    [DataRow("source", "medium", null, true)]
    [DataRow("source", "", "campaign", true)]
    [DataRow("source", null, "campaign", true)]
    [DataRow("", "medium", "campaign", true)]
    [DataRow(null, "medium", "campaign", true)]
    public void DadoUmaListaDeCampanhasDeveOuNaoLancarException(string source, string medium, string name, bool expectedExcepetion)
    {
        if (!expectedExcepetion)
        {
            new Campaign(source, medium, name);
            Assert.IsTrue(true);
        }
        else
        {
            try
            {
                new Campaign(source, medium, name);
                Assert.Fail();
            }
            catch (InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

       
        
    }
}