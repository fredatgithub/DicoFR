using CreateDictionary.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
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
    private readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    private readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      LoadLanguageCombobox();
      SetUsedLanguage();
      finalListOfWords.OrderBy(x => x).ToList();
      GetWindowValue();
      DisplayTitle();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
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

      CountListBoxWords();
    }

    private void CountListBoxWords()
    {
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

      if (originalMasterCount < masterFilenamecontent.Count)
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
          string line;
          while ((line = sr.ReadLine()) != null)
          {
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

    private void ButtonDeleteWord_Click(object sender, EventArgs e)
    {
      if (listBoxWords.Items.Count == 0)
      {
        MessageBox.Show("The list box is empty");
        return;
      }

      if (listBoxWords.SelectedIndex == -1)
      {
        MessageBox.Show("Please select a word in the listbox");
        return;
      }

      listBoxWords.Items.RemoveAt(listBoxWords.SelectedIndex);
      CountListBoxWords();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.textBoxSource = textBoxSource.Text;
      //Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      textBoxSource.Text = Settings.Default.textBoxSource;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(Language.French.ToString());
    }

    private void englishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(Language.English.ToString());
    }

    // copy the following methods if you don't have them yet (you shouldn't)

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          toolStripMenuFrench.Checked = false;
          englishToolStripMenuItem.Checked = true;
          fichierToolStripMenuItem.Text = languageDicoEn["MenuFile"];
          nouveauToolStripMenuItem.Text = languageDicoEn["MenuFileNew"];
          ouvrirToolStripMenuItem.Text = languageDicoEn["MenuFileOpen"];
          enregistrerToolStripMenuItem.Text = languageDicoEn["MenuFileSave"];
          enregistrersousToolStripMenuItem.Text = languageDicoEn["MenuFileSaveAs"];
          aperçuavantimpressionToolStripMenuItem.Text = languageDicoEn["MenuFilePrint"];
          imprimerToolStripMenuItem.Text = languageDicoEn["MenufilePageSetup"];
          quitterToolStripMenuItem.Text = languageDicoEn["MenufileQuit"];
          editionToolStripMenuItem.Text = languageDicoEn["MenuEdit"];
          annulerToolStripMenuItem.Text = languageDicoEn["MenuEditCancel"];
          rétablirToolStripMenuItem.Text = languageDicoEn["MenuEditRedo"];
          couperToolStripMenuItem.Text = languageDicoEn["MenuEditCut"];
          copierToolStripMenuItem.Text = languageDicoEn["MenuEditCopy"];
          collerToolStripMenuItem.Text = languageDicoEn["MenuEditPaste"];
          sélectionnertoutToolStripMenuItem.Text = languageDicoEn["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoEn["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoEn["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoEn["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoEn["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoEn["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoEn["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoEn["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoEn["MenuHelpSummary"];
          //indexToolStripMenuItem.Text = languageDicoEn["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoEn["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoEn["MenuHelpAbout"];

          break;
        case "French":
          toolStripMenuFrench.Checked = true;
          englishToolStripMenuItem.Checked = false;
          fichierToolStripMenuItem.Text = languageDicoFr["MenuFile"];
          nouveauToolStripMenuItem.Text = languageDicoFr["MenuFileNew"];
          ouvrirToolStripMenuItem.Text = languageDicoFr["MenuFileOpen"];
          enregistrerToolStripMenuItem.Text = languageDicoFr["MenuFileSave"];
          enregistrersousToolStripMenuItem.Text = languageDicoFr["MenuFileSaveAs"];
          aperçuavantimpressionToolStripMenuItem.Text = languageDicoFr["MenuFilePrint"];
          imprimerToolStripMenuItem.Text = languageDicoFr["MenufilePageSetup"];
          quitterToolStripMenuItem.Text = languageDicoFr["MenufileQuit"];
          editionToolStripMenuItem.Text = languageDicoFr["MenuEdit"];
          annulerToolStripMenuItem.Text = languageDicoFr["MenuEditCancel"];
          rétablirToolStripMenuItem.Text = languageDicoFr["MenuEditRedo"];
          couperToolStripMenuItem.Text = languageDicoFr["MenuEditCut"];
          copierToolStripMenuItem.Text = languageDicoFr["MenuEditCopy"];
          collerToolStripMenuItem.Text = languageDicoFr["MenuEditPaste"];
          sélectionnertoutToolStripMenuItem.Text = languageDicoFr["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoFr["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoFr["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoFr["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoFr["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoFr["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoFr["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoFr["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoFr["MenuHelpSummary"];
          //indexToolStripMenuItem.Text = languageDicoFr["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoFr["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoFr["MenuHelpAbout"];

          break;

      }
    }
       
    public enum Language
    {
      French,
      English
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        languageDicoEn.Add(i.name, i.englishValue);
        languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    private static void CreateLanguageFile()
    {
      var minimumVersion = new List<string>
          {
            "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
            "<Document>",
            "<DocumentVersion>",
            "<version> 1.0 </version>",
            "</DocumentVersion>",
            "<terms>",
             "<term>",
            "<name>MenuFile</name>",
            "<englishValue>File</englishValue>",
            "<frenchValue>Fichier</frenchValue>",
            "</term>",
            "  </terms>",
            "</Document>"
          };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }
  }
}
