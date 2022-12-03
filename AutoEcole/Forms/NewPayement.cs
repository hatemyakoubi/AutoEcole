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
    public partial class NewPayement : Form
    {
        private readonly FormPayement _parent;
        public string id, nomC, cinC, montantC;

        public NewPayement(FormPayement parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateInfo()
        {
            this.Text = "Modifier payement";
            btnNew.Text = "Modifier";
            nom.Text = nomC;
            montant.Text = montantC;
            cin.Text = cinC;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SaveInfo()
        {
            this.Text = "Ajouter Payement";
            btnNew.Text = "Ajouter";
        }
        public void ClearField()
        {
            cin.Text = nom.Text = cin.Text = montant.Text= string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DateTime datePayement = DateTime.Now;

            if ((cin.Text.Trim().Length < 8) || (cin.Text.Trim().Length > 8))
            {
                MessageBox.Show("le cin doit de 8 caractere");
                return;
            }
            if (nom.Text.Trim().Length < 2)
            {
                MessageBox.Show("le nom doit etre plus que 2 caractere");
                return;
            }
            if (montant.Text.Trim().Length < 3)
            {
                MessageBox.Show("le montant doit etre plus que 2 caractere");
                return;
            }
            if (btnNew.Text == "Ajouter")
            {
                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string reqPayment = "INSERT INTO payement VALUES(NULL,@montant,@cinCandidat,@nomCandidat,@datePayement)";
                MySqlCommand cmd = new MySqlCommand(reqPayment, con);
                cmd.Parameters.AddWithValue("@montant", float.Parse(montant.Text));
                cmd.Parameters.AddWithValue("@cinCandidat", cin.Text);
                cmd.Parameters.AddWithValue("@nomCandidat", nom.Text);
                cmd.Parameters.AddWithValue("@datePayement", datePayement);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Payement a été ajouter avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (btnNew.Text == "Modifier")
            {

                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string req = "UPDATE payement SET montant= @montant,cinCandidat= @cinCandidat,nomCandidat=@nomCandidat,datePayement=@datePayement WHERE idPayement=@id";
                MySqlCommand cmd = new MySqlCommand(req, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@montant", float.Parse(montant.Text));
                cmd.Parameters.AddWithValue("@cinCandidat", cin.Text);
                cmd.Parameters.AddWithValue("@nomCandidat", nom.Text);
                cmd.Parameters.AddWithValue("@datePayement", datePayement);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Payement a été modifier avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _parent.Display();


        }
    }
}
