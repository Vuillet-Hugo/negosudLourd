using System;
using Npgsql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace negosud
{
    public class User
    {
        public string email { get; set; }
        public string motdepasse { get; set; }
        public string UserName { get; set; }
        public User(string userName)
        {
            UserName = userName;
        }
    }
    internal class DbConnexion
    {
        public NpgsqlConnection Conn;
        private string Server = "db.dfgqsyvziksjxjztynlc.supabase.co";
        private string Password = "0lMUb1jX5nXmpRuS";
        private string UserId = "postgres";
        private string Port = "5432";
        private string Database = "postgres";
        public DbConnexion()
        {
            Conn = new NpgsqlConnection("Server=" + Server + "; Port = " + Port + "; User Id = " + UserId + "; Password = " + Password + "; Database = " + Database + "");
            openConn();
        }
        public void openConn()
        {
            Conn.Open();
        }
        public void closeConn()
        {
            Conn.Dispose();
        }
        public NpgsqlDataReader requete(string requete)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = Conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = requete;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


    }
}
