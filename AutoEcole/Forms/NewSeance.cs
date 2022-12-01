using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole.Forms
{
    public partial class NewSeance : Form
    {
        private readonly FormSeance _parent;
        public string id, nomC, dateS, typeS, moniteurS;
        public NewSeance(FormSeance parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void NewSeance_Load(object sender, EventArgs e)
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
            MySqlConnection con = new MySqlConnection(sql);
            con.Open();
            string req = " SELECT  CONCAT(prenom, ' ', nom) from candidat";
            MySqlCommand cmd = new MySqlCommand(req, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nom.Items.Add(dr.GetString(0));
            }
            con.Close();
            con.Open();
            string req2 = " SELECT  CONCAT(prenom, ' ', nom) from moniteur";
            MySqlCommand cmd2 = new MySqlCommand(req2, con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                moniteur.Items.Add(dr2.GetString(0));
            }
            con.Close();
        }

        public void updateInfo()
        {
            this.Text = "Modifier Payement";
            btnNew.Text = "Modifier";
            nom.Text = nomC;
            dateseance.Text = dateS;
            moniteur.Text = moniteurS;
            type.Text = typeS;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SaveInfo()
        {
            this.Text = "Ajouter Séance";
            btnNew.Text = "Ajouter";
        }
        public void ClearField()
        {
            moniteur.Text = nom.Text = moniteur.Text = type.Text = string.Empty;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DateTime datePayement = DateTime.Now;

            if (btnNew.Text == "Ajouter")
            {
                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string reqPayment = "INSERT INTO seance VALUES(NULL,@type,@nom,@date,@moniteur)";
                MySqlCommand cmd = new MySqlCommand(reqPayment, con);
                cmd.Parameters.AddWithValue("@type", type.SelectedItem);
                cmd.Parameters.AddWithValue("@nom", nom.SelectedItem);
                cmd.Parameters.AddWithValue("@date", dateseance.Value);
                cmd.Parameters.AddWithValue("@moniteur", moniteur.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Séance a été ajouter avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (btnNew.Text == "Modifier")
            {

                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string req = "UPDATE seance SET type_seance= @type,nomCandidat= @nom,dateSeance=@date,moniteur=@moniteur WHERE idSeance=@id";
                MySqlCommand cmd = new MySqlCommand(req, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@type", type.SelectedItem);
                cmd.Parameters.AddWithValue("@nom", nom.SelectedItem);
                cmd.Parameters.AddWithValue("@date", dateseance.Value);
                cmd.Parameters.AddWithValue("@moniteur", moniteur.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Séance a été modifier avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _parent.Display();
        }
    }
}
