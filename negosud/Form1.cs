using System;
using Npgsql;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace negosud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitter_Click(object sender, EventArgs e)
        {

        }

        private void motDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        DbConnexion db = new DbConnexion();
        private void connexion_Click(object sender, EventArgs e)
        {
            connexion.Enabled = false;
            connexion.Text = "Connexion en cours...";

            if (identifiant.Text == "" && motDePasse.Text == "")
            {
                textConnexion.Text = "champs vide";
                connexion.Enabled = true;
                connexion.Text = "Connexion";
            }
            else
            {
                NpgsqlDataReader reader = db.requete("SELECT * FROM utilisateur WHERE email = '" + identifiant.Text + "' AND motdepasse = '" + motDePasse.Text + "'");
                int result = reader.Read() ? 1 : 0;
                if (result == 1)
                {
                    int role = reader.GetOrdinal("role");
                    int roleValue = reader.GetInt16(role);
                    string userName = reader.GetString(reader.GetOrdinal("nom"));
                    User ConnectUser = new User(userName); // on crée un user avec le nom de l'user connecté
                    textConnexion.Text = "Connexion réussie";
                    connexion.Enabled = true;
                    connexion.Text = "Connexion";
                    if (roleValue == 1 || roleValue == 3) // admin = 1 , user = 2 , gestionnaire = 3
                    {
                        this.Hide();
                       DashBoard dashBoard = new DashBoard(ConnectUser); // on envoie l'user connecté à MainPage
                        dashBoard.Show();
                        db.closeConn();
                    }
                    else
                    {
                        textConnexion.Text = "Vous n'avez pas accèes à cette page";
                        connexion.Enabled = true;
                        connexion.Text = "Connexion";
                    }// champs correct mais pas admin
                }
                else
                {
                    textConnexion.Text = "Identifiant ou mot de passe incorrect";
                    connexion.Enabled = true;
                    connexion.Text = "Connexion";
                }// pas d'user dans la base de donnée
                reader.Close();
            }
        }
        
        
        private void ResetConnexionButton()
        {
            connexion.Enabled = true;
            connexion.Text = "Connexion";
        }

        private void titre_Click(object sender, EventArgs e)
        {

        }

        private void textConnexion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
