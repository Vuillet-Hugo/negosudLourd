namespace negosud
{
    partial class Form1
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
            this.connexion = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.identifiant = new System.Windows.Forms.TextBox();
            this.motDePasse = new System.Windows.Forms.TextBox();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.Label();
            this.textConnexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.Color.Silver;
            this.connexion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.connexion.FlatAppearance.BorderSize = 0;
            this.connexion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexion.Location = new System.Drawing.Point(197, 421);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(350, 62);
            this.connexion.TabIndex = 0;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // quitter
            // 
            this.quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quitter.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter.Location = new System.Drawing.Point(197, 518);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(350, 35);
            this.quitter.TabIndex = 1;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // identifiant
            // 
            this.identifiant.BackColor = System.Drawing.Color.Silver;
            this.identifiant.Location = new System.Drawing.Point(197, 214);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(349, 23);
            this.identifiant.TabIndex = 2;
            // 
            // motDePasse
            // 
            this.motDePasse.BackColor = System.Drawing.Color.Silver;
            this.motDePasse.Location = new System.Drawing.Point(197, 310);
            this.motDePasse.Name = "motDePasse";
            this.motDePasse.PasswordChar = '*';
            this.motDePasse.Size = new System.Drawing.Size(349, 23);
            this.motDePasse.TabIndex = 3;
            this.motDePasse.TextChanged += new System.EventHandler(this.motDePasse_TextChanged);
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentifiant.Location = new System.Drawing.Point(193, 189);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(112, 22);
            this.labelIdentifiant.TabIndex = 4;
            this.labelIdentifiant.Text = "Identifiant";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.Location = new System.Drawing.Point(193, 285);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(135, 22);
            this.labelMdp.TabIndex = 5;
            this.labelMdp.Text = "Mot de passe";
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(190, 42);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(368, 42);
            this.titre.TabIndex = 6;
            this.titre.Text = "Page Administateur";
            this.titre.Click += new System.EventHandler(this.titre_Click);
            // 
            // textConnexion
            // 
            this.textConnexion.AutoSize = true;
            this.textConnexion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConnexion.Location = new System.Drawing.Point(194, 366);
            this.textConnexion.Name = "textConnexion";
            this.textConnexion.Size = new System.Drawing.Size(0, 22);
            this.textConnexion.TabIndex = 7;
            this.textConnexion.Click += new System.EventHandler(this.textConnexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(755, 630);
            this.Controls.Add(this.textConnexion);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelIdentifiant);
            this.Controls.Add(this.motDePasse);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.connexion);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connexion;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.TextBox motDePasse;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label textConnexion;
    }
}

