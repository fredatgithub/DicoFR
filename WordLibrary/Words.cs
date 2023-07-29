using System;
using System.Text.RegularExpressions;

namespace WordLibrary
{
  public static class Words
  {
    public static string RemoveNumbers(string input)
    {
      // Use a regular expression to match any digit (\d) and replace it with an empty string.
      string result = Regex.Replace(input, @"\d", "");
      return result;
    }

    public static string RemovePunctuation(string word)
    {
      word = word.Trim();
      word = word.ToLower();
      word = RemoveSymbols(word);

      if (RemoveNumbers(word).Length == 0)
      {
        return string.Empty;
      }

      word = RemoveNumbers(word).Trim();
      return word;
    }

    private static string RemoveSymbols(string word)
    {
      if (word == "aujourd'hui" || word == "ci-dessous" || word == "ci-dessus")
      {
        return word;
      }

      word = word.Replace(".", "");
      word = word.Replace(",", "");
      word = word.Replace(":", "");
      word = word.Replace("«", "");
      word = word.Replace("»", "");
      word = word.Replace("(", "");
      word = word.Replace(")", "");
      word = word.Replace("{", "");
      word = word.Replace("}", "");
      word = word.Replace("+", "");
      word = word.Replace("-", "");
      word = word.Replace(";", "");
      word = word.Replace("\"", "");
      word = word.Replace("!", "");
      word = word.Replace("<", "");
      word = word.Replace(">", "");
      word = word.Replace("?", "");
      return word;
    }

    public static string SplitTwoWordsIfItHasQuote(string word)
    {
      string result = string.Empty;
      if (word.Contains("'"))
      {
        int position = word.IndexOf("'");
        result = word.Substring(0, position + 1);
        result += "|";
        result += word.Substring(position + 1);
      }
      else //|| word == "a-t-il"
      {
        result = word;
      }

      return result;
    }
  }
}
