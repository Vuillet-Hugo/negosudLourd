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
            this.TableauPorduit = new System.Windows.Forms.DataGridView();
            this.NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableauPorduit)).BeginInit();
            this.SuspendLayout();
            // 
            // TableauPorduit
            // 
            this.TableauPorduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauPorduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomProduit});
            this.TableauPorduit.Location = new System.Drawing.Point(51, 39);
            this.TableauPorduit.Name = "TableauPorduit";
            this.TableauPorduit.RowHeadersWidth = 51;
            this.TableauPorduit.RowTemplate.Height = 24;
            this.TableauPorduit.Size = new System.Drawing.Size(555, 188);
            this.TableauPorduit.TabIndex = 0;
            // 
            // NomProduit
            // 
            this.NomProduit.HeaderText = "Column1";
            this.NomProduit.MinimumWidth = 6;
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Width = 125;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableauPorduit);
            this.Name = "MainPage";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TableauPorduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableauPorduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProduit;
    }
}