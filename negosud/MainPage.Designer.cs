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
            this.dataGridProduit = new System.Windows.Forms.DataGridView();
            this.AddProduit = new System.Windows.Forms.TabPage();
            this.bonDeCommande = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonAllProduit = new System.Windows.Forms.Button();
            this.buttonVinBlanc = new System.Windows.Forms.Button();
            this.buttonVinRouge = new System.Windows.Forms.Button();
            this.buttonProduitSeuil = new System.Windows.Forms.Button();
            this.TextBoxRobe = new System.Windows.Forms.RichTextBox();
            this.TextBoxAnnee = new System.Windows.Forms.RichTextBox();
            this.TextBoxQuantite = new System.Windows.Forms.RichTextBox();
            this.TextBoxVolume = new System.Windows.Forms.RichTextBox();
            this.TextBoxNom = new System.Windows.Forms.RichTextBox();
            this.TextBoxSeuil = new System.Windows.Forms.RichTextBox();
            this.TextBoxPrix = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelRobe = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelSeuil = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.buttonAddProduit = new System.Windows.Forms.Button();
            this.buttonVinRose = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Produit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduit)).BeginInit();
            this.AddProduit.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.Produit);
            this.tabControl.Controls.Add(this.AddProduit);
            this.tabControl.Controls.Add(this.bonDeCommande);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(1, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1284, 635);
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
            this.Produit.Location = new System.Drawing.Point(4, 32);
            this.Produit.Name = "Produit";
            this.Produit.Padding = new System.Windows.Forms.Padding(3);
            this.Produit.Size = new System.Drawing.Size(1276, 599);
            this.Produit.TabIndex = 0;
            this.Produit.Text = "Tout les produits";
            // 
            // dataGridProduit
            // 
            this.dataGridProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduit.Location = new System.Drawing.Point(-4, 65);
            this.dataGridProduit.Name = "dataGridProduit";
            this.dataGridProduit.RowHeadersWidth = 51;
            this.dataGridProduit.RowTemplate.Height = 24;
            this.dataGridProduit.Size = new System.Drawing.Size(1279, 552);
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
            this.AddProduit.Controls.Add(this.TextBox);
            this.AddProduit.Controls.Add(this.TextBoxPrix);
            this.AddProduit.Controls.Add(this.TextBoxSeuil);
            this.AddProduit.Controls.Add(this.TextBoxNom);
            this.AddProduit.Controls.Add(this.TextBoxVolume);
            this.AddProduit.Controls.Add(this.TextBoxQuantite);
            this.AddProduit.Controls.Add(this.TextBoxAnnee);
            this.AddProduit.Controls.Add(this.TextBoxRobe);
            this.AddProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduit.Location = new System.Drawing.Point(4, 32);
            this.AddProduit.Name = "AddProduit";
            this.AddProduit.Size = new System.Drawing.Size(1276, 599);
            this.AddProduit.TabIndex = 2;
            this.AddProduit.Text = "Ajouter des Produits";
            // 
            // bonDeCommande
            // 
            this.bonDeCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bonDeCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonDeCommande.Location = new System.Drawing.Point(4, 32);
            this.bonDeCommande.Name = "bonDeCommande";
            this.bonDeCommande.Size = new System.Drawing.Size(1276, 599);
            this.bonDeCommande.TabIndex = 3;
            this.bonDeCommande.Text = "Bon de commande";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(821, 5);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 16);
            this.labelUser.TabIndex = 2;
            // 
            // buttonAllProduit
            // 
            this.buttonAllProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAllProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllProduit.Location = new System.Drawing.Point(7, 6);
            this.buttonAllProduit.Name = "buttonAllProduit";
            this.buttonAllProduit.Size = new System.Drawing.Size(220, 53);
            this.buttonAllProduit.TabIndex = 1;
            this.buttonAllProduit.Text = "Tout les produits";
            this.buttonAllProduit.UseVisualStyleBackColor = false;
            // 
            // buttonVinBlanc
            // 
            this.buttonVinBlanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVinBlanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinBlanc.Location = new System.Drawing.Point(233, 6);
            this.buttonVinBlanc.Name = "buttonVinBlanc";
            this.buttonVinBlanc.Size = new System.Drawing.Size(220, 53);
            this.buttonVinBlanc.TabIndex = 2;
            this.buttonVinBlanc.Text = "Vin blanc";
            this.buttonVinBlanc.UseVisualStyleBackColor = false;
            // 
            // buttonVinRouge
            // 
            this.buttonVinRouge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVinRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinRouge.Location = new System.Drawing.Point(459, 6);
            this.buttonVinRouge.Name = "buttonVinRouge";
            this.buttonVinRouge.Size = new System.Drawing.Size(220, 53);
            this.buttonVinRouge.TabIndex = 3;
            this.buttonVinRouge.Text = "Vin Rouge";
            this.buttonVinRouge.UseVisualStyleBackColor = false;
            // 
            // buttonProduitSeuil
            // 
            this.buttonProduitSeuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonProduitSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduitSeuil.Location = new System.Drawing.Point(911, 6);
            this.buttonProduitSeuil.Name = "buttonProduitSeuil";
            this.buttonProduitSeuil.Size = new System.Drawing.Size(220, 53);
            this.buttonProduitSeuil.TabIndex = 4;
            this.buttonProduitSeuil.Text = "Produits en rupture";
            this.buttonProduitSeuil.UseVisualStyleBackColor = false;
            // 
            // TextBoxRobe
            // 
            this.TextBoxRobe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxRobe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxRobe.Location = new System.Drawing.Point(313, 87);
            this.TextBoxRobe.Name = "TextBoxRobe";
            this.TextBoxRobe.Size = new System.Drawing.Size(291, 44);
            this.TextBoxRobe.TabIndex = 0;
            this.TextBoxRobe.Text = "";
            // 
            // TextBoxAnnee
            // 
            this.TextBoxAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxAnnee.Location = new System.Drawing.Point(907, 87);
            this.TextBoxAnnee.Name = "TextBoxAnnee";
            this.TextBoxAnnee.Size = new System.Drawing.Size(291, 44);
            this.TextBoxAnnee.TabIndex = 1;
            this.TextBoxAnnee.Text = "";
            // 
            // TextBoxQuantite
            // 
            this.TextBoxQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxQuantite.Location = new System.Drawing.Point(313, 213);
            this.TextBoxQuantite.Name = "TextBoxQuantite";
            this.TextBoxQuantite.Size = new System.Drawing.Size(291, 44);
            this.TextBoxQuantite.TabIndex = 2;
            this.TextBoxQuantite.Text = "";
            // 
            // TextBoxVolume
            // 
            this.TextBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxVolume.Location = new System.Drawing.Point(610, 87);
            this.TextBoxVolume.Name = "TextBoxVolume";
            this.TextBoxVolume.Size = new System.Drawing.Size(291, 44);
            this.TextBoxVolume.TabIndex = 3;
            this.TextBoxVolume.Text = "";
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxNom.Location = new System.Drawing.Point(16, 87);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(291, 44);
            this.TextBoxNom.TabIndex = 4;
            this.TextBoxNom.Text = "";
            // 
            // TextBoxSeuil
            // 
            this.TextBoxSeuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxSeuil.Location = new System.Drawing.Point(610, 213);
            this.TextBoxSeuil.Name = "TextBoxSeuil";
            this.TextBoxSeuil.Size = new System.Drawing.Size(291, 44);
            this.TextBoxSeuil.TabIndex = 5;
            this.TextBoxSeuil.Text = "";
            // 
            // TextBoxPrix
            // 
            this.TextBoxPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBoxPrix.Location = new System.Drawing.Point(907, 213);
            this.TextBoxPrix.Name = "TextBoxPrix";
            this.TextBoxPrix.Size = new System.Drawing.Size(291, 44);
            this.TextBoxPrix.TabIndex = 6;
            this.TextBoxPrix.Text = "";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBox.Location = new System.Drawing.Point(16, 213);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(291, 44);
            this.TextBox.TabIndex = 7;
            this.TextBox.Text = "";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 64);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(93, 20);
            this.labelNom.TabIndex = 8;
            this.labelNom.Text = "Nom du vin";
            // 
            // labelRobe
            // 
            this.labelRobe.AutoSize = true;
            this.labelRobe.Location = new System.Drawing.Point(309, 64);
            this.labelRobe.Name = "labelRobe";
            this.labelRobe.Size = new System.Drawing.Size(97, 20);
            this.labelRobe.TabIndex = 9;
            this.labelRobe.Text = "Robe du vin";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(606, 64);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(157, 20);
            this.labelFormat.TabIndex = 10;
            this.labelFormat.Text = "Taille de la bouteille";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(903, 190);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(79, 20);
            this.labelPrix.TabIndex = 11;
            this.labelPrix.Text = "Prix unité";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(309, 190);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(77, 20);
            this.labelQuantite.TabIndex = 12;
            this.labelQuantite.Text = "Quantité ";
            // 
            // labelSeuil
            // 
            this.labelSeuil.AutoSize = true;
            this.labelSeuil.Location = new System.Drawing.Point(606, 190);
            this.labelSeuil.Name = "labelSeuil";
            this.labelSeuil.Size = new System.Drawing.Size(156, 20);
            this.labelSeuil.TabIndex = 13;
            this.labelSeuil.Text = "Seuil de commande";
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Location = new System.Drawing.Point(903, 64);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(80, 20);
            this.labelAnnee.TabIndex = 14;
            this.labelAnnee.Text = "Millésime";
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Location = new System.Drawing.Point(12, 190);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(47, 20);
            this.labelFournisseur.TabIndex = 15;
            this.labelFournisseur.Text = "Cave";
            // 
            // buttonAddProduit
            // 
            this.buttonAddProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAddProduit.Location = new System.Drawing.Point(465, 306);
            this.buttonAddProduit.Name = "buttonAddProduit";
            this.buttonAddProduit.Size = new System.Drawing.Size(288, 61);
            this.buttonAddProduit.TabIndex = 16;
            this.buttonAddProduit.Text = "Ajouter le produit";
            this.buttonAddProduit.UseVisualStyleBackColor = false;
            // 
            // buttonVinRose
            // 
            this.buttonVinRose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonVinRose.Location = new System.Drawing.Point(685, 6);
            this.buttonVinRose.Name = "buttonVinRose";
            this.buttonVinRose.Size = new System.Drawing.Size(220, 53);
            this.buttonVinRose.TabIndex = 5;
            this.buttonVinRose.Text = "Vin rosé";
            this.buttonVinRose.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 686);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Gestion du stocks";
            this.tabControl.ResumeLayout(false);
            this.Produit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduit)).EndInit();
            this.AddProduit.ResumeLayout(false);
            this.AddProduit.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button buttonAddProduit;
        private System.Windows.Forms.Button buttonVinRose;
    }
}