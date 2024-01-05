namespace negosud
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            this.menuStripBoard = new System.Windows.Forms.MenuStrip();
            this.deconnexionMenuBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterMenuBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelUserBoard = new System.Windows.Forms.Label();
            this.buttonProduitTotal = new System.Windows.Forms.Button();
            this.buttonProduitSeuil = new System.Windows.Forms.Button();
            this.buttonFournisseur = new System.Windows.Forms.Button();
            this.buttonInventaire = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonSiteWeb = new System.Windows.Forms.Button();
            this.menuStripBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripBoard
            // 
            this.menuStripBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStripBoard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStripBoard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionMenuBoard,
            this.quitterMenuBoard});
            this.menuStripBoard.Location = new System.Drawing.Point(0, 0);
            this.menuStripBoard.Name = "menuStripBoard";
            this.menuStripBoard.Size = new System.Drawing.Size(1175, 36);
            this.menuStripBoard.TabIndex = 0;
            this.menuStripBoard.Text = "menuStrip1";
            // 
            // deconnexionMenuBoard
            // 
            this.deconnexionMenuBoard.Name = "deconnexionMenuBoard";
            this.deconnexionMenuBoard.Size = new System.Drawing.Size(140, 32);
            this.deconnexionMenuBoard.Text = "Deconnexion";
            // 
            // quitterMenuBoard
            // 
            this.quitterMenuBoard.Name = "quitterMenuBoard";
            this.quitterMenuBoard.Size = new System.Drawing.Size(88, 32);
            this.quitterMenuBoard.Text = "Quitter";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelUserBoard
            // 
            this.labelUserBoard.AutoSize = true;
            this.labelUserBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelUserBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserBoard.Location = new System.Drawing.Point(787, 9);
            this.labelUserBoard.Name = "labelUserBoard";
            this.labelUserBoard.Size = new System.Drawing.Size(79, 25);
            this.labelUserBoard.TabIndex = 2;
            this.labelUserBoard.Text = "Bonjour";
            // 
            // buttonProduitTotal
            // 
            this.buttonProduitTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonProduitTotal.Enabled = false;
            this.buttonProduitTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduitTotal.Location = new System.Drawing.Point(66, 148);
            this.buttonProduitTotal.Name = "buttonProduitTotal";
            this.buttonProduitTotal.Size = new System.Drawing.Size(413, 105);
            this.buttonProduitTotal.TabIndex = 3;
            this.buttonProduitTotal.Text = "Produit Total";
            this.buttonProduitTotal.UseVisualStyleBackColor = false;
            // 
            // buttonProduitSeuil
            // 
            this.buttonProduitSeuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonProduitSeuil.Enabled = false;
            this.buttonProduitSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduitSeuil.Location = new System.Drawing.Point(644, 148);
            this.buttonProduitSeuil.Name = "buttonProduitSeuil";
            this.buttonProduitSeuil.Size = new System.Drawing.Size(453, 105);
            this.buttonProduitSeuil.TabIndex = 4;
            this.buttonProduitSeuil.Text = "Produit en rupture";
            this.buttonProduitSeuil.UseVisualStyleBackColor = false;
            // 
            // buttonFournisseur
            // 
            this.buttonFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFournisseur.Location = new System.Drawing.Point(66, 479);
            this.buttonFournisseur.Name = "buttonFournisseur";
            this.buttonFournisseur.Size = new System.Drawing.Size(413, 116);
            this.buttonFournisseur.TabIndex = 5;
            this.buttonFournisseur.Text = "Catalogue Fournisseurs";
            this.buttonFournisseur.UseVisualStyleBackColor = false;
            // 
            // buttonInventaire
            // 
            this.buttonInventaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventaire.Location = new System.Drawing.Point(644, 308);
            this.buttonInventaire.Name = "buttonInventaire";
            this.buttonInventaire.Size = new System.Drawing.Size(453, 116);
            this.buttonInventaire.TabIndex = 6;
            this.buttonInventaire.Text = "Inventaire";
            this.buttonInventaire.UseVisualStyleBackColor = false;
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Location = new System.Drawing.Point(68, 308);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(411, 116);
            this.buttonStock.TabIndex = 7;
            this.buttonStock.Text = "Gérer les stocks";
            this.buttonStock.UseVisualStyleBackColor = false;
            // 
            // buttonSiteWeb
            // 
            this.buttonSiteWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSiteWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiteWeb.Location = new System.Drawing.Point(644, 479);
            this.buttonSiteWeb.Name = "buttonSiteWeb";
            this.buttonSiteWeb.Size = new System.Drawing.Size(452, 115);
            this.buttonSiteWeb.TabIndex = 8;
            this.buttonSiteWeb.Text = "Accéder au site Web";
            this.buttonSiteWeb.UseVisualStyleBackColor = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::negosud.Properties.Resources.dashBoardFond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1175, 688);
            this.Controls.Add(this.buttonSiteWeb);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonInventaire);
            this.Controls.Add(this.buttonFournisseur);
            this.Controls.Add(this.buttonProduitSeuil);
            this.Controls.Add(this.buttonProduitTotal);
            this.Controls.Add(this.labelUserBoard);
            this.Controls.Add(this.menuStripBoard);
            this.MainMenuStrip = this.menuStripBoard;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.menuStripBoard.ResumeLayout(false);
            this.menuStripBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripBoard;
        private System.Windows.Forms.ToolStripMenuItem deconnexionMenuBoard;
        private System.Windows.Forms.ToolStripMenuItem quitterMenuBoard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelUserBoard;
        private System.Windows.Forms.Button buttonProduitTotal;
        private System.Windows.Forms.Button buttonProduitSeuil;
        private System.Windows.Forms.Button buttonFournisseur;
        private System.Windows.Forms.Button buttonInventaire;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonSiteWeb;
    }
}