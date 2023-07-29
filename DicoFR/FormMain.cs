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
          AddToListBox(AddIfNotAlreadyIn(splittedNewWord, listBoxWords), listBoxWords);
          AddToTextBox(AddIfNotAlreadyIn(splittedNewWord, textBoxVerif), textBoxVerif);
          splittedNewWord = newWord.Substring(position + 1);
          AddToListBox(AddIfNotAlreadyIn(splittedNewWord, listBoxWords), listBoxWords);
          AddToTextBox(AddIfNotAlreadyIn(splittedNewWord, textBoxVerif), textBoxVerif);
          continue;
        }

        if (!string.IsNullOrEmpty(newWord))
        {
          AddToListBox(AddIfNotAlreadyIn(newWord, listBoxWords), listBoxWords);
          AddToTextBox(AddIfNotAlreadyIn(newWord, textBoxVerif), textBoxVerif);
        }
      }

      labelCount.Text = $"Count: {listBoxWords.Items.Count}";
    }

    private void AddToListBox(string word, ListBox listBox)
    {
      if (!string.IsNullOrEmpty(word))
      {
        listBox.Items.Add(word);
      }
    }

    private void AddToTextBox(string word, TextBox textBox)
    {
      if (!string.IsNullOrEmpty(word))
      {
        textBox.Text += $"{word}{Environment.NewLine}";
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
