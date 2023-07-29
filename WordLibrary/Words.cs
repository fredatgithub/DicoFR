﻿using System.Text.RegularExpressions;

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
      word = word.Replace(".", "");
      word = word.Replace(",", "");
      // remove numbers
      if (RemoveNumbers(word).Length == 0)
      {
        return string.Empty;
      }

      word = RemoveNumbers(word).Trim();
      return word;
    }

    public static string SplitTwoWordsIfItHasQuote(string word)
    {
      string result = string.Empty;
      if (word.Contains("'"))
      {
        int position = word.IndexOf("'");
        result = word.Substring(0, position);
        result += "|";
        result = word.Substring(position + 1);
      }
      else
      {
        result = word;
      }

      return result;
    }
  }
}