namespace Createdictionary.TestProject
{
  [TestClass]
  public class UnitTestDictionary
  {
    [TestMethod]
    [DataRow("123456789", "")]
    [DataRow("mlmlkmlk123456789", "mlmlkmlk")]
    [DataRow("azerty", "azerty")]
    [DataRow("", "")]
    [DataRow("a1z1e1r1t1y1", "azerty")]
    public void TestMethod_RemoveNumbers(string source, string expected)
    {
      var result = Words.RemoveNumbers(source);
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("", "")]
    [DataRow("l'utilisation", "l'|utilisation")]
    public void TestMethod_SplitTwoWordsIfItHasQuote(string source, string expected)
    {
      var result = Words.SplitTwoWordsIfItHasQuote(source); 
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("", "")]
    [DataRow(" ", "")]
    [DataRow("utilisation", "utilisation")]
    [DataRow("utilisation.", "utilisation")]
    [DataRow("utilisation,", "utilisation")]
    public void TestMethod_RemovePunctuation(string source, string expected)
    {
      var result = Words.RemovePunctuation(source);
      Assert.AreEqual(expected, result);
    }
  }
}