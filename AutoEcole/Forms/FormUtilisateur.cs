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
            if (e.ColumnIndex == 0)
            {
                //edit
                form.ClearField();
                form.id = CandidatDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString();
                form.cinC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[3].Value.ToString();
                form.nomC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[4].Value.ToString();
                form.prenomC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[5].Value.ToString();
                form.dateNaissC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[6].Value.ToString();
                form.adresseC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[7].Value.ToString();
                form.telephoneC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[8].Value.ToString();
                form.CategorieC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[9].Value.ToString();
                form.typeinscriptionC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[10].Value.ToString();
                form.situationC = CandidatDataGridView.Rows[e.ColumnIndex].Cells[11].Value.ToString();              
                form.updateInfo();
                form.ShowDialog();
                Console.WriteLine(form.id);
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
               if( MessageBox.Show("étez-vous sur de supprimer ce candidat?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBCandidat.deleteCandidat(CandidatDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString());                 
                    Display();
                }
                return;
            }
        }
    }
}
