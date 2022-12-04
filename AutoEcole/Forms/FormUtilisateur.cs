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
    public partial class FormUtilisateur : Form
    {
        NewCandidat form;
        int indexRow;
        public FormUtilisateur()
        {
            InitializeComponent();
            LoadTheme();
            form = new NewCandidat(this);
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
            DBCandidat.DisplayAndSearchCandidat("SELECT idCandidat,cin,nom,prenom,dateNaiss,adresse,telephone,cat_permis,typeinscription,situation FROM candidat", CandidatDataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //NewCandidat candidatForm = new NewCandidat(this);
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormUtilisateur_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBCandidat.DisplayAndSearchCandidat("select idCandidat,cin,nom,prenom,dateNaiss,adresse,telephone,cat_permis,typeinscription,situation FROM candidat WHERE nom LIKE'%" + txtSearch.Text+"%' ", CandidatDataGridView);
        }

        //evenement sur le click d'une ligne sur Gridview pour récuperer les données de ligne selectionée
        private void CandidatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                indexRow = e.RowIndex;
                DataGridViewRow row = CandidatDataGridView.Rows[indexRow];
                connexion.id = row.Cells[0].Value.ToString();
                connexion.cin = row.Cells[1].Value.ToString();
                connexion.nom = row.Cells[2].Value.ToString();
                connexion.prenom = row.Cells[3].Value.ToString();
                connexion.date = row.Cells[4].Value.ToString();
                connexion.adresse = row.Cells[5].Value.ToString();
                connexion.tel = row.Cells[6].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
        }
    }
}
