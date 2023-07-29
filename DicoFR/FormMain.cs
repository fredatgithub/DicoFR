using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

    private List<string> finalListOfWords = new List<string>();
    private string masterFilename = "MasterList.txt";
    private string languageUsed = "French";

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadLanguageCombobox();
      SetUsedLanguage();
      finalListOfWords.OrderBy(x => x).ToList();
    }

    private void SetUsedLanguage()
    {
      languageUsed = comboBoxLanguage.SelectedItem.ToString();
      masterFilename = $"{languageUsed}-MasterList.txt";
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
        finalListOfWords.Add(word);
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

    private void ButtonSaveToFile_Click(object sender, EventArgs e)
    {
      var filename = $"{languageUsed}-WordList.txt";
      SaveToFile(filename, finalListOfWords.OrderBy(x => x).ToList());
      MessageBox.Show($"All the words have been saved into the file : {filename}");
    }

    private void SaveToFile(string filename, List<string> listOfWords)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, false))
        {
          foreach (string word in listOfWords)
          {
            sw.WriteLine(word);
          }
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    private void ButtonAddToMasterFile_Click(object sender, EventArgs e)
    {
      if (!File.Exists(masterFilename))
      {
        File.Create(masterFilename);
      }

      var masterFilenamecontent = ReadFile(masterFilename);
      var originalMasterCount = masterFilenamecontent.Count;
      foreach (var word in finalListOfWords)
      {
        if (!masterFilenamecontent.Contains(word))
        {
          masterFilenamecontent.Add(word);
        }
      }

      if (originalMasterCount <= masterFilenamecontent.Count)
      {
        var result = WriteListboxToFile(masterFilenamecontent, masterFilename);
        if (result)
        {
          MessageBox.Show("All the new words have been added to the master filename", "New words added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          MessageBox.Show("There was an error while writing new words to the master filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else
      {
        MessageBox.Show("No new word has been found and added to the master filename", "No new word", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private bool WriteListboxToFile(List<string> listcontent, string filename)
    {
      var result = true;
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, false))
        {
          foreach (var item in listcontent.OrderBy(x => x).ToList())
          {
            sw.WriteLine(item);
          }
        }
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    private List<string> ReadFile(string masterFilename)
    {
      var result = new List<string>();
      try
      {
        using (StreamReader sr = new StreamReader(masterFilename))
        {
          while (sr.Read() != -1)
          {
            var line = sr.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
              result.Add(line);
            }
          }
        }
      }
      catch (Exception)
      {
        // do nothing
      }

      return result;
    }

    private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
      SetUsedLanguage();
    }
  }
}
