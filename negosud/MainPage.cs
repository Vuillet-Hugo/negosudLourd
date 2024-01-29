using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace negosud
{
    public partial class MainPage : Form
    {
        public User CurrentUser; // user connecté
        public MainPage(User user)
        {
            InitializeComponent();
            CurrentUser = user; // On l'assigne à la variable currentUser
            labelUser.Text = "Bienvenue " + CurrentUser.UserName;
            DbConnexion connexion = new DbConnexion();
            NpgsqlDataReader reader = connexion.requete("SELECT * FROM produits");
            DataTable dt = new DataTable();
            if (reader.HasRows)
            {
                dt.Load(reader);
                dataGridProduit.DataSource = dt;
            }
        }
        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashBoard = new DashBoard(CurrentUser); 
            dashBoard.Show();
        }

        private void buttonAddProduit_Click(object sender, EventArgs e)
        {
            string newProduitNom = TextBoxNom.Text;
            string newProduitRobe = TextBoxRobe.Text;
            string newProduitCave = TextBoxCave.Text;
            string newProduitAnnee = TextBoxAnnee.Text;
            string newProduitVolume = TextBoxVolume.Text;
            int newProduitQuantite = Convert.ToInt32(TextBoxQuantite.Text);
            int newProduitSeuil = Convert.ToInt32(TextBoxSeuil.Text);
            int newProduitPrix = Convert.ToInt32(TextBoxPrix.Text);
            string idNewProduit = "(SELECT MAX(id) from produits)";
            string idCave = "(SELECT id from fournisseur WHERE nom = '"+newProduitCave+"')";
            string idCategorie = "(SELECT id from categorie WHERE nom = '"+newProduitRobe+"')";
            string idAttribut = "(SELECT id from attribut WHERE nom = '"+newProduitAnnee+"')";
            string idOption = "(SELECT id from option WHERE nom = '"+newProduitVolume+"')";
            string idPrix = "(SELECT id from prix WHERE id_produit = "+idNewProduit+")";
            
            DbConnexion db = new DbConnexion();
            db.CreateData("INSERT INTO produits (nom,fournisseur) VALUES ('"+newProduitNom+"',"+idCave+")");
            
            // check/création catégorie
            int categorieCount = db.CheckDataCount("SELECT COUNT(*) FROM categorie WHERE nom = '"+newProduitRobe+"'");
            if (categorieCount == 0)
            {
                db.CreateData("INSERT INTO categorie (nom) VALUES ('"+newProduitRobe+"')");
                db.CreateData("INSERT INTO produit_categorie (id_produit, id_categorie) VALUES ("+idNewProduit+", "+idCategorie+")");
            }
            else
            {
                db.CreateData("INSERT INTO produit_categorie (id_produit, id_categorie) VALUES ("+idNewProduit+", "+idCategorie+")");
            }

            // check/création attribut année
            int anneeCount = db.CheckDataCount("SELECT COUNT(*) FROM attribut WHERE nom = '"+newProduitAnnee+"'");
            if (anneeCount == 0)
            {
                db.CreateData("INSERT INTO attribut (nom) VALUES ('"+newProduitAnnee+"')");
                db.CreateData("INSERT INTO categorie_attribut (id_categorie, id_attribut) VALUES ("+idCategorie+", "+idAttribut+")");
            }
            else
            {
                db.CreateData("INSERT INTO categorie_attribut (id_categorie, id_attribut) VALUES ("+idCategorie+", "+idAttribut+")");
            }
            
            // check/création option volume
            int volumeCount = db.CheckDataCount("SELECT COUNT(*) FROM option WHERE nom = '"+newProduitVolume+"'");
            if (volumeCount == 0)
            {
                db.CreateData("INSERT INTO option (nom) VALUES ('"+newProduitVolume+"')");
                db.CreateData("INSERT INTO attribut_option (id_attribut, id_option) VALUES ("+idAttribut+", "+idOption+")");
            }
            else
            {
                db.CreateData("INSERT INTO attribut_option (id_attribut, id_option) VALUES ("+idAttribut+", "+idOption+")");
            }
            
            // création du prix en fonctions de ces variations
            db.CreateData("INSERT INTO prix (id_option, prix, id_produit) VALUES ("+idOption+", "+newProduitPrix+", "+idNewProduit+")");

            // création du stocks produit
            db.CreateData("INSERT INTO stocks (quantite, seuilcommande, id_prix) VALUES ("+newProduitQuantite+", "+newProduitSeuil+","+idPrix+")");
            
        }
        
    }
}
