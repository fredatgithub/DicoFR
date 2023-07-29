using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      foreach ( var word in wordsArray )
      {
        if (!listOfWords.Contains(word))
        {
          listOfWords.Add(word);
        }
      }

      listBoxWords.Items.Clear();
      foreach ( var word in listOfWords )
      {
        listBoxWords.Items.Add(RemovePunctuation(word));
      }

      labelCount.Text = $"Count: {listBoxWords.Items.Count}";
    }

    private string RemovePunctuation(string word)
    {
      word = word.Trim();
      word = word.ToLower();
      word = word.Replace(".", "");
      return word;
    }
  }
}
