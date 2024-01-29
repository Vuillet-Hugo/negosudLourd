namespace negosud
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Produit = new System.Windows.Forms.TabPage();
            this.buttonVinRose = new System.Windows.Forms.Button();
            this.buttonProduitSeuil = new System.Windows.Forms.Button();
            this.buttonVinRouge = new System.Windows.Forms.Button();
            this.buttonVinBlanc = new System.Windows.Forms.Button();
            this.buttonAllProduit = new System.Windows.Forms.Button();
            this.dataGridProduit = new System.Windows.Forms.DataGridView();
            this.AddProduit = new System.Windows.Forms.TabPage();
            this.buttonAddProduit = new System.Windows.Forms.Button();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.labelSeuil = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelRobe = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.TextBoxCave = new System.Windows.Forms.RichTextBox();
            this.TextBoxPrix = new System.Windows.Forms.RichTextBox();
            this.TextBoxSeuil = new System.Windows.Forms.RichTextBox();
            this.TextBoxNom = new System.Windows.Forms.RichTextBox();
            this.TextBoxVolume = new System.Windows.Forms.RichTextBox();
            this.TextBoxQuantite = new System.Windows.Forms.RichTextBox();
            this.TextBoxAnnee = new System.Windows.Forms.RichTextBox();
            this.TextBoxRobe = new System.Windows.Forms.RichTextBox();
            this.tabFournisseur = new System.Windows.Forms.TabPage();
            this.labelEmailFournisseur = new System.Windows.Forms.Label();
            this.labelTelephoneFournisseur = new System.Windows.Forms.Label();
            this.labelSiretFournisseur = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.AddFournisseur = new System.Windows.Forms.Button();
            this.TextBoxEmailFournisseur = new System.Windows.Forms.RichTextBox();
            this.TextBoxPhoneFournisseur = new System.Windows.Forms.RichTextBox();
            this.TextBoxAdresseFournisseur = new System.Windows.Forms.RichTextBox();
            this.TextBoxSiretFournisseur = new System.Windows.Forms.RichTextBox();
            this.TextBoxNomFournisseur = new System.Windows.Forms.RichTextBox();
            this.bonDeCommande = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelAdresseFournisseur = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Produit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduit)).BeginInit();
            this.AddProduit.SuspendLayout();
            this.tabFournisseur.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.Produit);
            this.tabControl.Controls.Add(this.AddProduit);
            this.tabControl.Controls.Add(this.tabFournisseur);
            this.tabControl.Controls.Add(this.bonDeCommande);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(1, 32);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(963, 516);
            this.tabControl.TabIndex = 0;
            // 
            // Produit
            // 
            this.Produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Produit.Controls.Add(this.buttonVinRose);
            this.Produit.Controls.Add(this.buttonProduitSeuil);
            this.Produit.Controls.Add(this.buttonVinRouge);
            this.Produit.Controls.Add(this.buttonVinBlanc);
            this.Produit.Controls.Add(this.buttonAllProduit);
            this.Produit.Controls.Add(this.dataGridProduit);
            this.Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produit.Location = new System.Drawing.Point(4, 28);
            this.Produit.Margin = new System.Windows.Forms.Padding(2);
            this.Produit.Name = "Produit";
            this.Produit.Padding = new System.Windows.Forms.Padding(2);
            this.Produit.Size = new System.Drawing.Size(955, 484);
            this.Produit.TabIndex = 0;
            this.Produit.Text = "Tout les produits";
            // 
            // buttonVinRose
            // 
            this.buttonVinRose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVinRose.Location = new System.Drawing.Point(514, 5);
            this.buttonVinRose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVinRose.Name = "buttonVinRose";
            this.buttonVinRose.Size = new System.Drawing.Size(165, 43);
            this.buttonVinRose.TabIndex = 5;
            this.buttonVinRose.Text = "Vin rosé";
            this.buttonVinRose.UseVisualStyleBackColor = false;
            // 
            // buttonProduitSeuil
            // 
            this.buttonProduitSeuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonProduitSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduitSeuil.Location = new System.Drawing.Point(683, 5);
            this.buttonProduitSeuil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProduitSeuil.Name = "buttonProduitSeuil";
            this.buttonProduitSeuil.Size = new System.Drawing.Size(165, 43);
            this.buttonProduitSeuil.TabIndex = 4;
            this.buttonProduitSeuil.Text = "Produits en rupture";
            this.buttonProduitSeuil.UseVisualStyleBackColor = false;
            // 
            // buttonVinRouge
            // 
            this.buttonVinRouge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVinRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinRouge.Location = new System.Drawing.Point(344, 5);
            this.buttonVinRouge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVinRouge.Name = "buttonVinRouge";
            this.buttonVinRouge.Size = new System.Drawing.Size(165, 43);
            this.buttonVinRouge.TabIndex = 3;
            this.buttonVinRouge.Text = "Vin Rouge";
            this.buttonVinRouge.UseVisualStyleBackColor = false;
            // 
            // buttonVinBlanc
            // 
            this.buttonVinBlanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVinBlanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinBlanc.Location = new System.Drawing.Point(175, 5);
            this.buttonVinBlanc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVinBlanc.Name = "buttonVinBlanc";
            this.buttonVinBlanc.Size = new System.Drawing.Size(165, 43);
            this.buttonVinBlanc.TabIndex = 2;
            this.buttonVinBlanc.Text = "Vin blanc";
            this.buttonVinBlanc.UseVisualStyleBackColor = false;
            // 
            // buttonAllProduit
            // 
            this.buttonAllProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAllProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllProduit.Location = new System.Drawing.Point(5, 5);
            this.buttonAllProduit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAllProduit.Name = "buttonAllProduit";
            this.buttonAllProduit.Size = new System.Drawing.Size(165, 43);
            this.buttonAllProduit.TabIndex = 1;
            this.buttonAllProduit.Text = "Tout les produits";
            this.buttonAllProduit.UseVisualStyleBackColor = false;
            // 
            // dataGridProduit
            // 
            this.dataGridProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduit.Location = new System.Drawing.Point(-3, 53);
            this.dataGridProduit.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridProduit.Name = "dataGridProduit";
            this.dataGridProduit.RowHeadersWidth = 51;
            this.dataGridProduit.RowTemplate.Height = 24;
            this.dataGridProduit.Size = new System.Drawing.Size(959, 448);
            this.dataGridProduit.TabIndex = 0;
            // 
            // AddProduit
            // 
            this.AddProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AddProduit.Controls.Add(this.buttonAddProduit);
            this.AddProduit.Controls.Add(this.labelFournisseur);
            this.AddProduit.Controls.Add(this.labelAnnee);
            this.AddProduit.Controls.Add(this.labelSeuil);
            this.AddProduit.Controls.Add(this.labelQuantite);
            this.AddProduit.Controls.Add(this.labelPrix);
            this.AddProduit.Controls.Add(this.labelFormat);
            this.AddProduit.Controls.Add(this.labelRobe);
            this.AddProduit.Controls.Add(this.labelNom);
            this.AddProduit.Controls.Add(this.TextBoxCave);
            this.AddProduit.Controls.Add(this.TextBoxPrix);
            this.AddProduit.Controls.Add(this.TextBoxSeuil);
            this.AddProduit.Controls.Add(this.TextBoxNom);
            this.AddProduit.Controls.Add(this.TextBoxVolume);
            this.AddProduit.Controls.Add(this.TextBoxQuantite);
            this.AddProduit.Controls.Add(this.TextBoxAnnee);
            this.AddProduit.Controls.Add(this.TextBoxRobe);
            this.AddProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduit.Location = new System.Drawing.Point(4, 28);
            this.AddProduit.Margin = new System.Windows.Forms.Padding(2);
            this.AddProduit.Name = "AddProduit";
            this.AddProduit.Size = new System.Drawing.Size(955, 484);
            this.AddProduit.TabIndex = 2;
            this.AddProduit.Text = "Ajouter des Produits";
            // 
            // buttonAddProduit
            // 
            this.buttonAddProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAddProduit.Location = new System.Drawing.Point(349, 249);
            this.buttonAddProduit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddProduit.Name = "buttonAddProduit";
            this.buttonAddProduit.Size = new System.Drawing.Size(216, 50);
            this.buttonAddProduit.TabIndex = 16;
            this.buttonAddProduit.Text = "Ajouter le produit";
            this.buttonAddProduit.UseVisualStyleBackColor = false;
            this.buttonAddProduit.Click += new System.EventHandler(this.buttonAddProduit_Click);
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Location = new System.Drawing.Point(9, 154);
            this.labelFournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(40, 17);
            this.labelFournisseur.TabIndex = 15;
            this.labelFournisseur.Text = "Cave";
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Location = new System.Drawing.Point(677, 52);
            this.labelAnnee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(65, 17);
            this.labelAnnee.TabIndex = 14;
            this.labelAnnee.Text = "Millésime";
            // 
            // labelSeuil
            // 
            this.labelSeuil.AutoSize = true;
            this.labelSeuil.Location = new System.Drawing.Point(454, 154);
            this.labelSeuil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeuil.Name = "labelSeuil";
            this.labelSeuil.Size = new System.Drawing.Size(132, 17);
            this.labelSeuil.TabIndex = 13;
            this.labelSeuil.Text = "Seuil de commande";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(232, 154);
            this.labelQuantite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(66, 17);
            this.labelQuantite.TabIndex = 12;
            this.labelQuantite.Text = "Quantité ";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(677, 154);
            this.labelPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(66, 17);
            this.labelPrix.TabIndex = 11;
            this.labelPrix.Text = "Prix unité";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(454, 52);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(134, 17);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Taille de la bouteille";
            // 
            // labelRobe
            // 
            this.labelRobe.AutoSize = true;
            this.labelRobe.Location = new System.Drawing.Point(232, 52);
            this.labelRobe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRobe.Name = "labelRobe";
            this.labelRobe.Size = new System.Drawing.Size(84, 17);
            this.labelRobe.TabIndex = 9;
            this.labelRobe.Text = "Robe du vin";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(9, 52);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(79, 17);
            this.labelNom.TabIndex = 8;
            this.labelNom.Text = "Nom du vin";
            // 
            // TextBoxCave
            // 
            this.TextBoxCave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxCave.Location = new System.Drawing.Point(12, 173);
            this.TextBoxCave.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCave.Name = "TextBoxCave";
            this.TextBoxCave.Size = new System.Drawing.Size(219, 36);
            this.TextBoxCave.TabIndex = 7;
            this.TextBoxCave.Text = "";
            // 
            // TextBoxPrix
            // 
            this.TextBoxPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxPrix.Location = new System.Drawing.Point(680, 173);
            this.TextBoxPrix.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPrix.Name = "TextBoxPrix";
            this.TextBoxPrix.Size = new System.Drawing.Size(219, 36);
            this.TextBoxPrix.TabIndex = 6;
            this.TextBoxPrix.Text = "";
            // 
            // TextBoxSeuil
            // 
            this.TextBoxSeuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxSeuil.Location = new System.Drawing.Point(458, 173);
            this.TextBoxSeuil.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSeuil.Name = "TextBoxSeuil";
            this.TextBoxSeuil.Size = new System.Drawing.Size(219, 36);
            this.TextBoxSeuil.TabIndex = 5;
            this.TextBoxSeuil.Text = "";
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxNom.Location = new System.Drawing.Point(12, 71);
            this.TextBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(219, 36);
            this.TextBoxNom.TabIndex = 4;
            this.TextBoxNom.Text = "";
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxVolume.Location = new System.Drawing.Point(458, 71);
            this.TextBoxVolume.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(219, 36);
            this.TextBoxVolume.TabIndex = 3;
            this.TextBoxVolume.Text = "";
            // 
            // TextBoxQuantite
            // 
            this.TextBoxQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxQuantite.Location = new System.Drawing.Point(235, 173);
            this.TextBoxQuantite.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxQuantite.Name = "TextBoxQuantite";
            this.TextBoxQuantite.Size = new System.Drawing.Size(219, 36);
            this.TextBoxQuantite.TabIndex = 2;
            this.TextBoxQuantite.Text = "";
            // 
            // TextBoxAnnee
            // 
            this.TextBoxAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxAnnee.Location = new System.Drawing.Point(680, 71);
            this.TextBoxAnnee.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxAnnee.Name = "TextBoxAnnee";
            this.TextBoxAnnee.Size = new System.Drawing.Size(219, 36);
            this.TextBoxAnnee.TabIndex = 1;
            this.TextBoxAnnee.Text = "";
            // 
            // TextBoxRobe
            // 
            this.TextBoxRobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxRobe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxRobe.Location = new System.Drawing.Point(235, 71);
            this.TextBoxRobe.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxRobe.Name = "TextBoxRobe";
            this.TextBoxRobe.Size = new System.Drawing.Size(219, 36);
            this.TextBoxRobe.TabIndex = 0;
            this.TextBoxRobe.Text = "";
            // 
            // tabFournisseur
            // 
            this.tabFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabFournisseur.Controls.Add(this.labelAdresseFournisseur);
            this.tabFournisseur.Controls.Add(this.labelEmailFournisseur);
            this.tabFournisseur.Controls.Add(this.labelTelephoneFournisseur);
            this.tabFournisseur.Controls.Add(this.labelSiretFournisseur);
            this.tabFournisseur.Controls.Add(this.labelNomFournisseur);
            this.tabFournisseur.Controls.Add(this.AddFournisseur);
            this.tabFournisseur.Controls.Add(this.TextBoxEmailFournisseur);
            this.tabFournisseur.Controls.Add(this.TextBoxPhoneFournisseur);
            this.tabFournisseur.Controls.Add(this.TextBoxAdresseFournisseur);
            this.tabFournisseur.Controls.Add(this.TextBoxSiretFournisseur);
            this.tabFournisseur.Controls.Add(this.TextBoxNomFournisseur);
            this.tabFournisseur.Location = new System.Drawing.Point(4, 28);
            this.tabFournisseur.Name = "tabFournisseur";
            this.tabFournisseur.Size = new System.Drawing.Size(955, 484);
            this.tabFournisseur.TabIndex = 4;
            this.tabFournisseur.Text = "Ajouter un fournisseur";
            // 
            // labelEmailFournisseur
            // 
            this.labelEmailFournisseur.Location = new System.Drawing.Point(7, 218);
            this.labelEmailFournisseur.Name = "labelEmailFournisseur";
            this.labelEmailFournisseur.Size = new System.Drawing.Size(116, 22);
            this.labelEmailFournisseur.TabIndex = 12;
            this.labelEmailFournisseur.Text = "Email";
            // 
            // labelTelephoneFournisseur
            // 
            this.labelTelephoneFournisseur.Location = new System.Drawing.Point(218, 218);
            this.labelTelephoneFournisseur.Name = "labelTelephoneFournisseur";
            this.labelTelephoneFournisseur.Size = new System.Drawing.Size(133, 22);
            this.labelTelephoneFournisseur.TabIndex = 10;
            this.labelTelephoneFournisseur.Text = "Téléphone";
            // 
            // labelSiretFournisseur
            // 
            this.labelSiretFournisseur.Location = new System.Drawing.Point(221, 66);
            this.labelSiretFournisseur.Name = "labelSiretFournisseur";
            this.labelSiretFournisseur.Size = new System.Drawing.Size(122, 21);
            this.labelSiretFournisseur.TabIndex = 7;
            this.labelSiretFournisseur.Text = "Siret";
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.Location = new System.Drawing.Point(7, 67);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(121, 23);
            this.labelNomFournisseur.TabIndex = 6;
            this.labelNomFournisseur.Text = "Nom";
            // 
            // AddFournisseur
            // 
            this.AddFournisseur.Location = new System.Drawing.Point(432, 243);
            this.AddFournisseur.Name = "AddFournisseur";
            this.AddFournisseur.Size = new System.Drawing.Size(202, 33);
            this.AddFournisseur.TabIndex = 5;
            this.AddFournisseur.Text = "Ajouter";
            this.AddFournisseur.UseVisualStyleBackColor = true;
            // 
            // TextBoxEmailFournisseur
            // 
            this.TextBoxEmailFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxEmailFournisseur.Location = new System.Drawing.Point(7, 243);
            this.TextBoxEmailFournisseur.Name = "TextBoxEmailFournisseur";
            this.TextBoxEmailFournisseur.Size = new System.Drawing.Size(205, 33);
            this.TextBoxEmailFournisseur.TabIndex = 4;
            this.TextBoxEmailFournisseur.Text = "";
            // 
            // TextBoxPhoneFournisseur
            // 
            this.TextBoxPhoneFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxPhoneFournisseur.Location = new System.Drawing.Point(218, 243);
            this.TextBoxPhoneFournisseur.Name = "TextBoxPhoneFournisseur";
            this.TextBoxPhoneFournisseur.Size = new System.Drawing.Size(205, 33);
            this.TextBoxPhoneFournisseur.TabIndex = 3;
            this.TextBoxPhoneFournisseur.Text = "";
            // 
            // TextBoxAdresseFournisseur
            // 
            this.TextBoxAdresseFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxAdresseFournisseur.Location = new System.Drawing.Point(429, 93);
            this.TextBoxAdresseFournisseur.Name = "TextBoxAdresseFournisseur";
            this.TextBoxAdresseFournisseur.Size = new System.Drawing.Size(205, 33);
            this.TextBoxAdresseFournisseur.TabIndex = 2;
            this.TextBoxAdresseFournisseur.Text = "";
            // 
            // TextBoxSiretFournisseur
            // 
            this.TextBoxSiretFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxSiretFournisseur.Location = new System.Drawing.Point(218, 93);
            this.TextBoxSiretFournisseur.Name = "TextBoxSiretFournisseur";
            this.TextBoxSiretFournisseur.Size = new System.Drawing.Size(205, 33);
            this.TextBoxSiretFournisseur.TabIndex = 1;
            this.TextBoxSiretFournisseur.Text = "";
            // 
            // TextBoxNomFournisseur
            // 
            this.TextBoxNomFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxNomFournisseur.Location = new System.Drawing.Point(7, 93);
            this.TextBoxNomFournisseur.Name = "TextBoxNomFournisseur";
            this.TextBoxNomFournisseur.Size = new System.Drawing.Size(205, 33);
            this.TextBoxNomFournisseur.TabIndex = 0;
            this.TextBoxNomFournisseur.Text = "";
            // 
            // bonDeCommande
            // 
            this.bonDeCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bonDeCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonDeCommande.Location = new System.Drawing.Point(4, 28);
            this.bonDeCommande.Margin = new System.Windows.Forms.Padding(2);
            this.bonDeCommande.Name = "bonDeCommande";
            this.bonDeCommande.Size = new System.Drawing.Size(955, 484);
            this.bonDeCommande.TabIndex = 3;
            this.bonDeCommande.Text = "Bon de commande";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.dashBoardToolStripMenuItem, this.deconnexionToolStripMenuItem, this.quitterToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.dashBoardToolStripMenuItem.Text = "DashBoard";
            this.dashBoardToolStripMenuItem.Click += new System.EventHandler(this.dashBoardToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(112, 25);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(616, 4);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 13);
            this.labelUser.TabIndex = 2;
            // 
            // labelAdresseFournisseur
            // 
            this.labelAdresseFournisseur.Location = new System.Drawing.Point(432, 67);
            this.labelAdresseFournisseur.Name = "labelAdresseFournisseur";
            this.labelAdresseFournisseur.Size = new System.Drawing.Size(129, 23);
            this.labelAdresseFournisseur.TabIndex = 13;
            this.labelAdresseFournisseur.Text = "Adresse";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 557);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "Gestion du stocks";
            this.tabControl.ResumeLayout(false);
            this.Produit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduit)).EndInit();
            this.AddProduit.ResumeLayout(false);
            this.AddProduit.PerformLayout();
            this.tabFournisseur.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelAdresseFournisseur;

        private System.Windows.Forms.Label labelEmailFournisseur;

        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.Label labelSiretFournisseur;
        private System.Windows.Forms.Label labelTelephoneFournisseur;

        private System.Windows.Forms.Button AddFournisseur;

        private System.Windows.Forms.RichTextBox TextBoxPhoneFournisseur;
        private System.Windows.Forms.RichTextBox TextBoxEmailFournisseur;

        private System.Windows.Forms.RichTextBox TextBoxNomFournisseur;
        private System.Windows.Forms.RichTextBox TextBoxSiretFournisseur;
        private System.Windows.Forms.RichTextBox TextBoxAdresseFournisseur;

        private System.Windows.Forms.TabPage tabFournisseur;

        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Produit;
        private System.Windows.Forms.TabPage AddProduit;
        private System.Windows.Forms.TabPage bonDeCommande;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridProduit;
        private System.Windows.Forms.Button buttonVinRouge;
        private System.Windows.Forms.Button buttonVinBlanc;
        private System.Windows.Forms.Button buttonAllProduit;
        private System.Windows.Forms.Button buttonProduitSeuil;
        private System.Windows.Forms.RichTextBox TextBoxAnnee;
        private System.Windows.Forms.RichTextBox TextBoxRobe;
        private System.Windows.Forms.RichTextBox TextBoxPrix;
        private System.Windows.Forms.RichTextBox TextBoxSeuil;
        private System.Windows.Forms.RichTextBox TextBoxNom;
        private System.Windows.Forms.RichTextBox TextBoxVolume;
        private System.Windows.Forms.RichTextBox TextBoxQuantite;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.Label labelSeuil;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelRobe;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.RichTextBox TextBoxCave;
        private System.Windows.Forms.Button buttonAddProduit;
        private System.Windows.Forms.Button buttonVinRose;
    }
}