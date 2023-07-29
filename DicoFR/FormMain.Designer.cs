namespace DicoFR
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.buttonExtract = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listBoxWords = new System.Windows.Forms.ListBox();
      this.labelLanguage = new System.Windows.Forms.Label();
      this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
      this.progressBarMain = new System.Windows.Forms.ProgressBar();
      this.labelCount = new System.Windows.Forms.Label();
      this.textBoxVerif = new System.Windows.Forms.TextBox();
      this.buttonSaveToFile = new System.Windows.Forms.Button();
      this.buttonAddToMasterFile = new System.Windows.Forms.Button();
      this.buttonDeleteWord = new System.Windows.Forms.Button();
      this.toolStripMenuILanguage = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuFrench = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxSource
      // 
      this.textBoxSource.Location = new System.Drawing.Point(64, 142);
      this.textBoxSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxSource.Size = new System.Drawing.Size(534, 924);
      this.textBoxSource.TabIndex = 0;
      this.textBoxSource.Text = resources.GetString("textBoxSource.Text");
      // 
      // buttonExtract
      // 
      this.buttonExtract.Location = new System.Drawing.Point(630, 263);
      this.buttonExtract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonExtract.Name = "buttonExtract";
      this.buttonExtract.Size = new System.Drawing.Size(112, 35);
      this.buttonExtract.TabIndex = 1;
      this.buttonExtract.Text = "Extract -->";
      this.buttonExtract.UseVisualStyleBackColor = true;
      this.buttonExtract.Click += new System.EventHandler(this.ButtonExtract_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.toolStripMenuILanguage,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(1758, 25);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      // 
      // listBoxWords
      // 
      this.listBoxWords.FormattingEnabled = true;
      this.listBoxWords.ItemHeight = 20;
      this.listBoxWords.Location = new System.Drawing.Point(894, 142);
      this.listBoxWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBoxWords.Name = "listBoxWords";
      this.listBoxWords.Size = new System.Drawing.Size(216, 864);
      this.listBoxWords.Sorted = true;
      this.listBoxWords.TabIndex = 3;
      // 
      // labelLanguage
      // 
      this.labelLanguage.AutoSize = true;
      this.labelLanguage.Location = new System.Drawing.Point(630, 142);
      this.labelLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelLanguage.Name = "labelLanguage";
      this.labelLanguage.Size = new System.Drawing.Size(81, 20);
      this.labelLanguage.TabIndex = 4;
      this.labelLanguage.Text = "Language";
      // 
      // comboBoxLanguage
      // 
      this.comboBoxLanguage.FormattingEnabled = true;
      this.comboBoxLanguage.Location = new System.Drawing.Point(634, 200);
      this.comboBoxLanguage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.comboBoxLanguage.Name = "comboBoxLanguage";
      this.comboBoxLanguage.Size = new System.Drawing.Size(180, 28);
      this.comboBoxLanguage.TabIndex = 5;
      this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);
      // 
      // progressBarMain
      // 
      this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBarMain.Location = new System.Drawing.Point(0, 1141);
      this.progressBarMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.progressBarMain.Name = "progressBarMain";
      this.progressBarMain.Size = new System.Drawing.Size(1758, 40);
      this.progressBarMain.TabIndex = 6;
      // 
      // labelCount
      // 
      this.labelCount.AutoSize = true;
      this.labelCount.Location = new System.Drawing.Point(890, 1033);
      this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelCount.Name = "labelCount";
      this.labelCount.Size = new System.Drawing.Size(65, 20);
      this.labelCount.TabIndex = 7;
      this.labelCount.Text = "Count:0";
      // 
      // textBoxVerif
      // 
      this.textBoxVerif.Location = new System.Drawing.Point(1152, 142);
      this.textBoxVerif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxVerif.Multiline = true;
      this.textBoxVerif.Name = "textBoxVerif";
      this.textBoxVerif.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxVerif.Size = new System.Drawing.Size(236, 864);
      this.textBoxVerif.TabIndex = 8;
      // 
      // buttonSaveToFile
      // 
      this.buttonSaveToFile.Location = new System.Drawing.Point(634, 363);
      this.buttonSaveToFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonSaveToFile.Name = "buttonSaveToFile";
      this.buttonSaveToFile.Size = new System.Drawing.Size(112, 35);
      this.buttonSaveToFile.TabIndex = 9;
      this.buttonSaveToFile.Text = "Save to file";
      this.buttonSaveToFile.UseVisualStyleBackColor = true;
      this.buttonSaveToFile.Click += new System.EventHandler(this.ButtonSaveToFile_Click);
      // 
      // buttonAddToMasterFile
      // 
      this.buttonAddToMasterFile.Location = new System.Drawing.Point(634, 408);
      this.buttonAddToMasterFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonAddToMasterFile.Name = "buttonAddToMasterFile";
      this.buttonAddToMasterFile.Size = new System.Drawing.Size(151, 35);
      this.buttonAddToMasterFile.TabIndex = 10;
      this.buttonAddToMasterFile.Text = "Add to master file";
      this.buttonAddToMasterFile.UseVisualStyleBackColor = true;
      this.buttonAddToMasterFile.Click += new System.EventHandler(this.ButtonAddToMasterFile_Click);
      // 
      // buttonDeleteWord
      // 
      this.buttonDeleteWord.Location = new System.Drawing.Point(634, 318);
      this.buttonDeleteWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonDeleteWord.Name = "buttonDeleteWord";
      this.buttonDeleteWord.Size = new System.Drawing.Size(130, 35);
      this.buttonDeleteWord.TabIndex = 11;
      this.buttonDeleteWord.Text = "Delete word -->";
      this.buttonDeleteWord.UseVisualStyleBackColor = true;
      this.buttonDeleteWord.Click += new System.EventHandler(this.ButtonDeleteWord_Click);
      // 
      // toolStripMenuILanguage
      // 
      this.toolStripMenuILanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFrench,
            this.englishToolStripMenuItem});
      this.toolStripMenuILanguage.Name = "toolStripMenuILanguage";
      this.toolStripMenuILanguage.Size = new System.Drawing.Size(71, 19);
      this.toolStripMenuILanguage.Text = "Language";
      // 
      // toolStripMenuFrench
      // 
      this.toolStripMenuFrench.Name = "toolStripMenuFrench";
      this.toolStripMenuFrench.Size = new System.Drawing.Size(180, 22);
      this.toolStripMenuFrench.Text = "French";
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.englishToolStripMenuItem.Text = "English";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1758, 1181);
      this.Controls.Add(this.buttonDeleteWord);
      this.Controls.Add(this.buttonAddToMasterFile);
      this.Controls.Add(this.buttonSaveToFile);
      this.Controls.Add(this.textBoxVerif);
      this.Controls.Add(this.labelCount);
      this.Controls.Add(this.progressBarMain);
      this.Controls.Add(this.comboBoxLanguage);
      this.Controls.Add(this.labelLanguage);
      this.Controls.Add(this.listBoxWords);
      this.Controls.Add(this.buttonExtract);
      this.Controls.Add(this.textBoxSource);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormMain";
      this.Text = "Create Dictionary";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Button buttonExtract;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    private System.Windows.Forms.ListBox listBoxWords;
    private System.Windows.Forms.Label labelLanguage;
    private System.Windows.Forms.ComboBox comboBoxLanguage;
    private System.Windows.Forms.ProgressBar progressBarMain;
    private System.Windows.Forms.Label labelCount;
    private System.Windows.Forms.TextBox textBoxVerif;
    private System.Windows.Forms.Button buttonSaveToFile;
    private System.Windows.Forms.Button buttonAddToMasterFile;
    private System.Windows.Forms.Button buttonDeleteWord;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuILanguage;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuFrench;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
  }
}

