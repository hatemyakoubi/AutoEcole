using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void loginCin_MouseClick(object sender, MouseEventArgs e)
        {
            if (loginCin.Text == "CIN"){
            loginCin.Text = "";
            }
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            if (password.Text == "Mot de passe")
            {
                password.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if((loginCin.Text.Trim() == "")||(password.Text.Trim()==""))
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                MySqlConnection  con = new MySqlConnection("Server=localhost;Database=gestionEcole;Uid=root;Pwd=;");
                try
                {

                    con.Open();
                    string querry = "SELECT * FROM personne WHERE cinUser ='" + loginCin.Text + "' AND password ='" + password.Text + "' ";
                      var cmd = new MySqlCommand(querry, con);
                    cmd.ExecuteReader();
                      Form1 f = new Form1();
                      f.Show();
                      Login l = new Login();
                      l.Hide();
                }
                catch(Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
