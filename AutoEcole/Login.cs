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
        connexion c = new connexion();
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
                    string req = "select * from utilisateur where username=@username and password=@password ";            
                    MySqlCommand command = new MySqlCommand(req, con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(command);
                    command.Parameters.AddWithValue("@username", Username.Text);
                    command.Parameters.AddWithValue("@password", password.Text);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);
                    Console.WriteLine(adp.Fill(tbl));
                    MySqlDataReader r = command.ExecuteReader();
                    if (tbl.Rows.Count > 0)
                    {
                        // Console.WriteLine(tbl.Rows[1][].ToString());
                        r.Read();
                        if (r[3].ToString() == "Administrateur")
                        {
                            connexion.type = "Administrateur";
                        }
                        if (r[3].ToString() == "Moniteur")
                        {
                            connexion.type = "Moniteur";
                        }
                        if (r[3].ToString() == "Utilisateur")
                        {
                            connexion.type = "Utilisateur";
                        }
                        Console.WriteLine(connexion.type);
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
