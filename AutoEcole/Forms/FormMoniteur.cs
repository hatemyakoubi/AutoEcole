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
    public partial class FormMoniteur : Form
    {
        NewMoniteur form;
        int indexRow;
        public FormMoniteur()
        {
            InitializeComponent();
            LoadTheme();
            form = new NewMoniteur(this);
            this.Text = "Liste des personnels";
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        public void Display()
        {
            DBMoniteur.DisplayAndSearchPersonnel("SELECT idMoniteur,cin,nom,prenom,dateNaiss,adresse,telephone,dateRec,nbrConge,salaire,rib,NumCnss,role FROM moniteur", MoniteurDataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //NewCandidat candidatForm = new NewCandidat(this);
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

       
        //evenement sur le click d'une ligne sur Gridview pour récuperer les données de ligne selectionée
        private void MoniteurDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = MoniteurDataGridView.Rows[indexRow];
            connexion.id = row.Cells[0].Value.ToString();
            connexion.cin = row.Cells[1].Value.ToString();
            connexion.nom = row.Cells[2].Value.ToString();
            connexion.prenom = row.Cells[3].Value.ToString();
            connexion.date = row.Cells[4].Value.ToString();
            connexion.adresse = row.Cells[5].Value.ToString();
            connexion.tel = row.Cells[6].Value.ToString();
            connexion.dateRec = row.Cells[7].Value.ToString();
            connexion.conge = row.Cells[8].Value.ToString();
            connexion.salaire = row.Cells[9].Value.ToString();
            connexion.rib = row.Cells[10].Value.ToString();
            connexion.cnss = row.Cells[11].Value.ToString();
            connexion.role = row.Cells[12].Value.ToString();
            form.updateInfo();
            form.ShowDialog();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormMoniteur_Shown_1(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DBMoniteur.DisplayAndSearchPersonnel("SELECT idMoniteur,cin,nom,prenom,dateNaiss,adresse,telephone,dateRec,nbrConge,salaire,rib,NumCnss,role  FROM moniteur WHERE nom LIKE'%" + txtSearch.Text + "%' ", MoniteurDataGridView);

        }
    }
}
