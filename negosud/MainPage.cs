using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace negosud
{
    public partial class MainPage : Form
    {
        public User currentUser; // user connecté
        public MainPage(User user)
        {
            InitializeComponent();
            currentUser = user; // On l'assigne à la variable currentUser
            labelUser.Text = "Bienvenue  " + currentUser.UserName;
            DbConnexion connexion = new DbConnexion();
            NpgsqlDataReader reader = connexion.requete("SELECT * FROM produit");
            DataTable dt = new DataTable();
            if (reader.HasRows)
            {
                dt.Load(reader);
                dataGridProduit.DataSource = dt;
            }
        }
    }
}
