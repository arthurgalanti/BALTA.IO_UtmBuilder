using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    private readonly Url _url = new ("https://galanti.dev/");
    private readonly Campaign _cmp = new (
        "youtube",
        "video",
        "open_to_work",
        "youtube_event",
        "promotion",
        "notPaid");
    private const string Result = "https://galanti.dev/" +
                 "?utm_source=youtube" +
                 "&utm_medium=video" +
                 "&utm_campaign=open_to_work" +
                 "&utm_id=youtube_event" +
                 "&utm_term=promotion" +
                 "&utm_content=notPaid";
    [TestMethod]
    public void DeveRetornarUrlDeUtmValido()
    {
    var utm = new Utm(_url, _cmp);
    Assert.AreEqual(Result, utm.ToString());
    Assert.AreEqual(Result, (string)utm);
    }
    
    [TestMethod]
    public void DeveRetornarUtmDeUmUrlValido()
    {
        Utm utm = Result;
        Assert.AreEqual("https://galanti.dev/", utm.Url.Address);
        Assert.AreEqual("youtube", utm.Campaign.Source);
        Assert.AreEqual("video", utm.Campaign.Medium);
        Assert.AreEqual("open_to_work", utm.Campaign.Name);
        Assert.AreEqual("youtube_event", utm.Campaign.Id);
        Assert.AreEqual("promotion", utm.Campaign.Term);
        Assert.AreEqual("notPaid", utm.Campaign.Content);
    }
}