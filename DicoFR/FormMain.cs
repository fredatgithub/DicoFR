using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WordLibrary;

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
        var newWord = Words.RemovePunctuation(word);
        newWord = Words.SplitTwoWordsIfItHasQuote(newWord);
        if (newWord.Contains("|"))
        {
          var position = newWord.IndexOf("|");
          var splittedNewWord = newWord.Substring(0, position);
          listBoxWords.Items.Add(splittedNewWord);
          AddVerification(splittedNewWord);
          splittedNewWord = newWord.Substring(position + 1);
          listBoxWords.Items.Add(splittedNewWord);
          AddVerification(splittedNewWord);
          continue;
        }

        if (!string.IsNullOrEmpty(newWord))
        {
          listBoxWords.Items.Add(AddIfNotAlreadyIn(newWord, listBoxWords));
          AddVerification(AddIfNotAlreadyIn(newWord, textBoxVerif));
        }
      }

      labelCount.Text = $"Count: {listBoxWords.Items.Count}";
    }

    private void AddVerification(string newWord)
    {
      if (!string.IsNullOrEmpty(newWord))
      {
        textBoxVerif.Text += $"{newWord}{Environment.NewLine}";
      }
    }

    private string AddIfNotAlreadyIn(string word, ListBox listBox)
    {
      return listBox.Items.Contains(word) ? string.Empty : word;
    }

    private string AddIfNotAlreadyIn(string word, TextBox textBox)
    {
      return textBox.Text.Contains(word) ? string.Empty : word;
    }
  }
}
