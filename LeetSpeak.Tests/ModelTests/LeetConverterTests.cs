using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakConverterTests
  {
    [TestMethod]
    public void LeetSpeakConverter_eTransform_3()
    {
    LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
    Assert.AreEqual("3", leetConverterTest.LeetSpeakConverter("e"));
    }
  }
}