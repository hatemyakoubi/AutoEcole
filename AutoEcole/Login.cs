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
           // Login l = new Login();
            Form1 f = new Form1();

            if ((loginCin.Text.Trim() =="")||(password.Text.Trim()==""))
            {
                MessageBox.Show("Remplir les champs");
            }
            else
            {
                try
                {
                    string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                    MySqlConnection con = new MySqlConnection(sql);
                    con.Open();
                    string req = "select username, password from candidat where username=" + loginCin.Text + " and password=" + password.Text + " ";
                    MySqlDataAdapter adp = new MySqlDataAdapter(req, con);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);
                    if (tbl.Rows.Count > 0)
                    {
                        f.Show();
                        this.Hide();                       
                    }
                    else
                    {
                        MessageBox.Show("username où mot de passe incorrecte . \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur de connexion");
                }
                
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
