using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    class connexion
    {
        public static MySqlConnection con = null;

        public void ConnexionDB()
        {
          /*  con = new MySqlConnection("Server=localhost;Database=gestionEcole;Uid=root;Pwd=;");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("erreur de connexion \n" + ex.Message);
            }*/
        }
    }
}
