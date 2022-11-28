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
    class DBMoniteur
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
       /* public static void AddMoniteur(Moniteur cdt)
        {
            string req = "INSERT INTO moniteur VALUES (NULL,@nom,@prenom,@cin,@telephone,@dateNaiss,@adresse,@cat_permis,@username,@password,@typeinscription,@situation,@role,@dateIncription)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(req, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = cdt.nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = cdt.prenom;
            cmd.Parameters.Add("@cin", MySqlDbType.VarChar).Value = cdt.cin;
            cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = cdt.telephone;
            cmd.Parameters.Add("@dateNaiss", MySqlDbType.Date).Value = cdt.dateNaiss;
            cmd.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = cdt.adresse;
            cmd.Parameters.Add("@cat_permis", MySqlDbType.VarChar).Value = cdt.cat_permis;
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = cdt.nom;
            cmd.Parameters.Add("@passwod", MySqlDbType.VarChar).Value = cdt.cin;
            cmd.Parameters.Add("@typeinscription", MySqlDbType.VarChar).Value = cdt.typeinscription;
            cmd.Parameters.Add("@situation", MySqlDbType.VarChar).Value = cdt.situation;
            cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = cdt.role;
            cmd.Parameters.Add("@dateIncription", MySqlDbType.Date).Value = cdt.dateIncription;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("moniteur a été ajouter avc succées . \n" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erreur d\'ajout un moniteur. \n" + ex.Source, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }*/
        /*public static void Updatemoniteur(Moniteur cdt,string id)
        {
            string req = "UPDATE moniteur SET nom= @nom,prenom= @prenom,cin=@cin,telephone=@telephone,dateNaiss=@dateNaiss,adresse=@adresse,cat_permis=@catpermis,username=@username,password=@password,typeinscription=@typeinscription,situation=@situation WHERE idmoniteur=@id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(req, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = cdt.nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = cdt.prenom;
            cmd.Parameters.Add("@cin", MySqlDbType.VarChar).Value = cdt.cin;
            cmd.Parameters.Add("@telephone", MySqlDbType.VarChar).Value = cdt.telephone;
            cmd.Parameters.Add("@dateNaiss", MySqlDbType.VarChar).Value = cdt.dateNaiss;
            cmd.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = cdt.adresse;
            cmd.Parameters.Add("@catpermis", MySqlDbType.VarChar).Value = cdt.cat_permis;
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = cdt.username;
            cmd.Parameters.Add("@passwod", MySqlDbType.VarChar).Value = cdt.password;
            cmd.Parameters.Add("@typeinscription", MySqlDbType.VarChar).Value = cdt.typeinscription;
            cmd.Parameters.Add("@situation", MySqlDbType.VarChar).Value = cdt.situation;
            cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = cdt.role;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("moniteur a été modifier avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de modification un moniteur. \n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }*/

        public static void deletemoniteur(string id)
        {
            string req = "DELETE FROM moniteur WHERE idMoniteur=@id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(req, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("moniteur a été supprimer avec succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de suppression. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearchmoniteur(string querry, DataGridView dgv)
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
