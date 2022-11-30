using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    class DBPayement
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

            }catch(MySqlException ex)
            {
                MessageBox.Show("MySQL Connection. \n"+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return con;
        }
        public static void deletePayement(string id)
        {
            string req = "DELETE FROM payement WHERE idPayement=@id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(req, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payement a été supprimer avec succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de suppression. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearchPayement(string querry, DataGridView dgv)
        {
            string sql = querry;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();


        }


    }
}
