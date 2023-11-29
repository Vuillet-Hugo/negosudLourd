using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void connexion_Click(object sender, EventArgs e)
        {
            ConnexionUtilisateur();
        }
        private void ConnexionUtilisateur()
        {
            connexion.Enabled = false;
            connexion.Text = "Connexion en cours...";

            if (identifiant.Text == "" && motDePasse.Text == "")
            {
                textConnexion.Text = "Les champs sont vides";
                ResetConnexionButton();
            }
            else
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=db.dfgqsyvziksjxjztynlc.supabase.co; Port = 6543; User Id = postgres; Password = 0lMUb1jX5nXmpRuS; Database = postgres"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM utilisateurs WHERE email = @identifiant AND motdepasse = @motDePasse";

                        cmd.Parameters.AddWithValue("@identifiant", identifiant.Text);
                        cmd.Parameters.AddWithValue("@motDePasse", motDePasse.Text);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            int result = reader.Read() ? 1 : 0;

                            if (result == 1)
                            {
                                int role = reader.GetOrdinal("role");
                                int roleValue = reader.GetInt16(role);
                                textConnexion.Text = "Connexion réussie";
                                if (roleValue == 1 || roleValue == 3)
                                {
                                    this.Hide();
                                    MainPage mainPage = new MainPage();
                                    mainPage.Show();
                                }
                                else
                                {
                                    textConnexion.Text = "Vous n'avez pas accès à cette page";
                                }
                            }
                            else
                            {
                                textConnexion.Text = "Identifiant ou mot de passe incorrect";
                            }
                        }
                    }
                }
                ResetConnexionButton();
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
    }
}
