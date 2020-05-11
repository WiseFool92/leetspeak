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

    [TestMethod]
    public void LeetSpeakConverter_sTransform_z()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("pz", leetConverterTest.LeetSpeakConverter("ps"));
    }

    [TestMethod]
    public void LeetSpeakConverter_sTransformFirstLetter_s()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("np sq", leetConverterTest.LeetSpeakConverter("np sq"));
    }

    [TestMethod]
    public void LeetSpeakConverter_sTransform0Index_s()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("Sally", leetConverterTest.LeetSpeakConverter("Sally"));
    }

    [TestMethod]
    public void LeetSpeakConverter_StringTransform_l337()
    {
      LeetSpeakTranslate leetConverterTest = new LeetSpeakTranslate();
      Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", leetConverterTest.LeetSpeakConverter("Don't you love these 'String' exercises? I do!"));
    }
  }
}