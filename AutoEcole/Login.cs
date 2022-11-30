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
            if (Username.Text == "Nom"){
            Username.Text = "";
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

            if ((Username.Text.Equals("Nom"))||(password.Text.Equals("Mot de passe")))
            {
                MessageBox.Show("Remplir les champs . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //cnx bd
                    string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                    // variable de cnx
                    MySqlConnection con = new MySqlConnection(sql);
                    con.Open();
                    string req = "select username, password from candidat where username=@username and password=@password ";            
                    MySqlCommand command = new MySqlCommand(req, con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(command);
                    command.Parameters.AddWithValue("@username", Username.Text);
                    command.Parameters.AddWithValue("@password", password.Text);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);
                    if (tbl.Rows.Count > 0)
                    {
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("username où mot de passe incorrecte . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(SqlException ex )
                {
                    MessageBox.Show("Erreur de connexion\n"+ex.Message);
                }
                
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
