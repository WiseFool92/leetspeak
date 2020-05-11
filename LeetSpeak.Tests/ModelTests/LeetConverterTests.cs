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

    [TestMethod]
    public void LeetSpeakerConverter_oTransform_0()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("0", leetConverterTest.LeetSpeakConverter("o"));
    }

    [TestMethod]
    public void LeetSpeakConverter_ITransform_1()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("1", leetConverterTest.LeetSpeakConverter("I"));
    }

    [TestMethod]
    public void LeetSpeakConverter_tTransform_7()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("7", leetConverterTest.LeetSpeakConverter("t"));
    }
  }
}