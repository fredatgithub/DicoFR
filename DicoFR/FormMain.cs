using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DicoFR
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadLanguageCombobox();
    }

    private void LoadLanguageCombobox()
    {
      comboBoxLanguage.Items.Clear();
      comboBoxLanguage.Items.Add("French");
      comboBoxLanguage.Items.Add("English");
      comboBoxLanguage.Items.Add("Spanish");
      comboBoxLanguage.Items.Add("German");
      comboBoxLanguage.Items.Add("Italian");
      comboBoxLanguage.SelectedIndex = 0;
    }

    private void ButtonExtract_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxSource.Text))
      {
        return;
      }

      var sourceText = textBoxSource.Text;
      var wordsArray = sourceText.Split(' ');
      var listOfWords = new List<string>();
      foreach (var word in wordsArray)
      {
        if (!listOfWords.Contains(word))
        {
          listOfWords.Add(word);
        }
      }

      listBoxWords.Items.Clear();
      foreach (var word in listOfWords)
      {
        var newWord = RemovePunctuation(word);
        if (newWord.Contains("'"))
        {
          int position = newWord.IndexOf("'");
          listBoxWords.Items.Add(newWord.Substring(0, position));
          AddVerification(newWord);
          listBoxWords.Items.Add(newWord.Substring(position + 1));
          AddVerification(newWord);
          continue;
        }

        if (!string.IsNullOrEmpty(newWord))
        {
          listBoxWords.Items.Add(newWord);
          AddVerification(newWord);
        }

      }

      labelCount.Text = $"Count: {listBoxWords.Items.Count}";
    }

    private void AddVerification(string newWord)
    {
      textBoxVerif.Text += $"{newWord}{Environment.NewLine}";
    }

    private string RemovePunctuation(string word)
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

    public static string RemoveNumbers(string input)
    {
      // Use a regular expression to match any digit (\d) and replace it with an empty string.
      string result = Regex.Replace(input, @"\d", "");
      return result;
    }
  }
}
