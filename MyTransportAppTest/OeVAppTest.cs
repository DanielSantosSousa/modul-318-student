using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissTransport;

namespace MyTransportAppTest
{
  [TestClass]
  public class OeVAppTest
  {
    [TestMethod]
    public void StationSearchTest()
    {
      ITransport Transport = new Transport();
      string SearchString = "luz";
      string Expected = "Luzern";
      Assert.AreEqual(Expected, Transport.GetStations(SearchString).StationList[0].Name);
    }
  }
}
