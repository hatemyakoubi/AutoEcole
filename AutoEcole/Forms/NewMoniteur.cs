using Microsoft.OData.Edm;
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
    public partial class NewMoniteur : Form
    {
        private readonly FormMoniteur _parent;
        public string id, nomC, prenomC, cinC, telephoneC, adresseC, congeM,posteM,dateNaissC,dateRecM,ribM,salaireM, cnssM;

        public NewMoniteur(FormMoniteur parent)
        {
            InitializeComponent();
            _parent = parent;
            
        }
        public void updateInfo()
        {
            this.Text = "Modifier personnel";
            btnNew.Text = "Modifier";
            btnAnnuler.Text = "Supprimer";
            nom.Text = connexion.nom;
            prenom.Text = connexion.prenom;
            cin.Text = connexion.cin;
            telephone.Text = connexion.tel;
            adresse.Text = connexion.adresse;
            conge.Text = connexion.conge;
            rib.Text = connexion.rib;
            cnss.Text = connexion.cnss;
            dateNaiss.Text = connexion.date;
            dateRec.Text = connexion.dateRec;
            poste.Text = connexion.role;
            salaire.Text = connexion.salaire;

        }

        public void SaveInfo()
        {
            this.Text = "Ajouter personnel";
            btnNew.Text = "Ajouter";
            btnAnnuler.Text = "Annuler";
        }
        public void ClearField()
        {
            cin.Text = nom.Text = prenom.Text = adresse.Text = conge.Text = telephone.Text= conge.Text=rib.Text=cnss.Text=salaire.Text=  string.Empty;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (btnAnnuler.Text == "Annuler")
            {
                this.Close();
            }
            if (btnAnnuler.Text == "Supprimer")
            {
                if (MessageBox.Show("étez-vous sur de supprimer ce payement?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBMoniteur.deletePersonnel(connexion.id);
                    _parent.Display();
                    ClearField();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DateTime dateIncription = DateTime.Now;

            if ((cin.Text.Trim().Length < 8)|| (cin.Text.Trim().Length > 8))
            {
                MessageBox.Show("le cin doit de 8 caractere");
                return;
            }
            if (nom.Text.Trim().Length < 2)
            {
                MessageBox.Show("le nom doit etre plus que 2 caractere");
                return;
            }
            if (prenom.Text.Trim().Length < 2)
            {
                MessageBox.Show("le prenom doit etre plus que 2 caractere");
                return;
            }
            if (cin.Text.Trim().Length < 8)
            {
                MessageBox.Show("le cin doit de 8 caractere");
                return;
            }
            if (adresse.Text.Trim().Length < 3)
            {
                MessageBox.Show("l\'adresse doit etre suprieur à 3 caractere");
                return;
            }
            if (telephone.Text.Trim().Length < 8)
            {
                MessageBox.Show("le n° de télèphone doit de 8 caractere");
                return;
            }
            if (conge.Text.Trim()=="")
            {
                MessageBox.Show("champs de nbrs de jours du congé est vide");
                return;
            }
            if (cnss.Text.Trim().Length<8)
            {
                MessageBox.Show("Vérifier le numéro de CNSS");
                return;
            }
            if (salaire.Text.Trim().Length < 3)
            {
                MessageBox.Show("Vérifier le salaire");
                return;
            }
            if (btnNew.Text == "Ajouter")
            {
                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string req = "INSERT INTO moniteur VALUES (NULL,@nom,@prenom,@cin,@telephone,@dateNaiss,@adresse,@username,@password,@dateRec,@nbrconge,@salaire,@rib,@cnss,@poste,@dateIncription)";
                string reqUser = "INSERT INTO utilisateur VALUES(NULL,@username,@password,@role)";
                MySqlCommand cmd = new MySqlCommand(req, con);
                MySqlCommand cmdU = new MySqlCommand(reqUser, con);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                cmd.Parameters.AddWithValue("@cin", cin.Text);
                cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                cmd.Parameters.AddWithValue("@dateNaiss", dateNaiss.Value);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@username", nom.Text);
                cmd.Parameters.AddWithValue("@password", cin.Text);
                cmd.Parameters.AddWithValue("@dateRec", dateRec.Value);
                cmd.Parameters.AddWithValue("@nbrconge", int.Parse(conge.Text));
                cmd.Parameters.AddWithValue("@salaire", double.Parse(salaire.Text));
                cmd.Parameters.AddWithValue("@rib", rib.Text);
                cmd.Parameters.AddWithValue("@cnss", cnss.Text);
                cmd.Parameters.AddWithValue("@poste", poste.SelectedItem);
                cmd.Parameters.AddWithValue("@dateIncription", dateIncription);
                cmd.ExecuteNonQuery();
                //execution req user
                cmdU.Parameters.AddWithValue("@username", nom.Text);
                cmdU.Parameters.AddWithValue("@password", cin.Text);
                cmdU.Parameters.AddWithValue("@role", poste.SelectedItem);
                cmdU.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Personnel a été ajouter avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (btnNew.Text == "Modifier")
            {

                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string req = "UPDATE moniteur SET nom=@nom,prenom=@prenom,cin=@cin,telephone=@telephone,dateNaiss=@dateNaiss,adresse=@adresse,username=@username,password=@password,dateRec=@dateRec,nbrconge=@nbrconge,salaire=@salaire,rib=@rib,NumCnss=@cnss,role=@poste WHERE idMoniteur=@id";
                MySqlCommand cmd = new MySqlCommand(req, con);
                cmd.Parameters.AddWithValue("@id", connexion.id);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                cmd.Parameters.AddWithValue("@cin", cin.Text);
                cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                cmd.Parameters.AddWithValue("@dateNaiss", dateNaiss.Value);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@username", nom.Text);
                cmd.Parameters.AddWithValue("@password", cin.Text);
                cmd.Parameters.AddWithValue("@dateRec", dateRec.Value);
                cmd.Parameters.AddWithValue("@nbrconge", int.Parse(conge.Text));
                cmd.Parameters.AddWithValue("@salaire", double.Parse(salaire.Text));
                cmd.Parameters.AddWithValue("@rib", rib.Text);
                cmd.Parameters.AddWithValue("@cnss", cnss.Text);
                cmd.Parameters.AddWithValue("@poste", poste.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Personnel a été modifier avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _parent.Display();


        }
    }
}
