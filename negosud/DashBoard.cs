using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negosud
{
    public partial class DashBoard : Form
    {
        public User CurrentUser;
        public DashBoard(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(CurrentUser);
            mainpage.Show();
            this.Hide();
        }
    }
}
