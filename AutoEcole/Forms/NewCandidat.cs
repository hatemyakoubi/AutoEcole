﻿using Microsoft.OData.Edm;
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
    public partial class NewCandidat : Form
    {
        private readonly FormUtilisateur _parent;
        public string id, nomC, prenomC, cinC, telephoneC, adresseC, cat_permis, typeinscriptionC,CategorieC,dateNaissC,situationC;
        
        public NewCandidat(FormUtilisateur parent)
        {
            InitializeComponent();
            _parent = parent;
            
        }
        public void updateInfo()
        {
            this.Text = "Modifier un candidat";
            btnNew.Text = "Modifier";
            nom.Text = nomC;
            prenom.Text = prenomC;
            cin.Text = cinC;
            telephone.Text = telephoneC;
            adresse.Text = adresseC;
            typeInscri.Text = typeinscriptionC;
            Categorie.Text = CategorieC;
            dateNaiss.Text = dateNaissC;
            if (situationC == "Sans code")
            {
                SansCode.Checked = true;
            }
            else
            {
                if (situationC == "Avec code")
                {
                    AvecCode.Checked=true;
                }
                else
                {
                    permisObtenu.Checked = true;
                }
            }

        }

        public void SaveInfo()
        {
            this.Text = "Nouveau un candidat";
            btnNew.Text = "Ajouter";
        }
        public void ClearField()
        {
            cin.Text = nom.Text = prenom.Text = adresse.Text = solde.Text = telephone.Text=  string.Empty;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string situation;
            DateTime dateIncription = DateTime.Now;
            if (SansCode.Checked == true)
            {
                situation = "Sans code";
            }
            else
            {
                if (AvecCode.Checked == true)
                {
                    situation = "Avec code";
                }
                else
                {
                    situation = "Permis obtenu";
                }
            }

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
            if(btnNew.Text == "Ajouter")
            {
                
               /* Candidat cdt = new Candidat(nom.Text.Trim(),prenom.Text.Trim(),cin.Text.Trim(),telephone.Text.Trim(),dateNaiss.Value,adresse.Text.Trim(),Categorie.SelectedItem.ToString(),nom.Text.Trim(),cin.Text.Trim(),typeInscri.SelectedItem.ToString(),situation,"ROLE_CANDIDAT",@dateIncription);
                 DBCandidat.AddCandidat(cdt);*/
                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string req = "INSERT INTO candidat VALUES (NULL,@nom,@prenom,@cin,@telephone,@dateNaiss,@adresse,@cat_permis,@username,@password,@typeinscription,@situation,@role,@dateIncription)";
                MySqlCommand cmd = new MySqlCommand(req, con);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                cmd.Parameters.AddWithValue("@cin", cin.Text);
                cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                cmd.Parameters.AddWithValue("@dateNaiss", dateNaiss.Value);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@cat_permis", Categorie.SelectedItem);
                cmd.Parameters.AddWithValue("@username", nom.Text);
                cmd.Parameters.AddWithValue("@password", cin.Text);
                cmd.Parameters.AddWithValue("@typeinscription", typeInscri.SelectedItem);
                cmd.Parameters.AddWithValue("@situation", situation);
                cmd.Parameters.AddWithValue("@role", "Utilisateur");
                cmd.Parameters.AddWithValue("@dateIncription", dateIncription);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Candidat a été ajouter avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (btnNew.Text == "Modifier")
            {

               /* Candidat cdt = new Candidat(nom.Text.Trim(), prenom.Text.Trim(), cin.Text.Trim(), telephone.Text.Trim(), dateNaiss.Value, adresse.Text.Trim(), Categorie.SelectedItem.ToString(), nom.Text.Trim(), cin.Text.Trim(), typeInscri.SelectedItem.ToString(), situation, "ROLE_CANDIDAT", @dateIncription);
                DBCandidat.UpdateCandidat(cdt, id);*/
                string sql = "datasource=localhost;port=3306;username=root;password=;database=gestionecole";
                MySqlConnection con = new MySqlConnection(sql);
                con.Open();
                string req = "UPDATE candidat SET nom= @nom,prenom= @prenom,cin=@cin,telephone=@telephone,dateNaiss=@dateNaiss,adresse=@adresse,cat_permis=@catpermis,username=@username,password=@password,typeinscription=@typeinscription,situation=@situation WHERE idCandidat=@id";
                MySqlCommand cmd = new MySqlCommand(req, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nom", nom.Text);
                cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                cmd.Parameters.AddWithValue("@cin", cin.Text);
                cmd.Parameters.AddWithValue("@telephone", telephone.Text);
                cmd.Parameters.AddWithValue("@dateNaiss", dateNaiss.Value);
                cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                cmd.Parameters.AddWithValue("@catpermis", Categorie.SelectedItem);
                cmd.Parameters.AddWithValue("@username", nom.Text);
                cmd.Parameters.AddWithValue("@password", cin.Text);
                cmd.Parameters.AddWithValue("@typeinscription", typeInscri.SelectedItem);
                cmd.Parameters.AddWithValue("@situation", situation);
                cmd.Parameters.AddWithValue("@role", "Utilisateur");
                cmd.Parameters.AddWithValue("@dateIncription", dateIncription);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearField();
                MessageBox.Show("Candidat a été modifier avc succées . \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            _parent.Display();


        }
    }
}
