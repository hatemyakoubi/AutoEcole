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
        public FormMoniteur()
        {
            InitializeComponent();
            LoadTheme();
            form = new NewMoniteur(this);
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
            DBCandidat.DisplayAndSearchCandidat("SELECT idMoniteur,cin,nom,prenom,dateNaiss,adresse,telephone,cat_permis,typeinscription,situation FROM moniteur", MoniteurDataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //NewCandidat candidatForm = new NewCandidat(this);
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }
        private void FormMoniteur_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBCandidat.DisplayAndSearchCandidat("select idMoniteur,cin,nom,prenom,dateNaiss,adresse,telephone,cat_permis,typeinscription,situation FROM moniteur WHERE nom LIKE'%" + txtSearch.Text + "%' ", MoniteurDataGridView);
        }
        //evenement sur le click d'une ligne sur Gridview pour récuperer les données de ligne selectionée
        private void MoniteurDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                form.ClearField();
                form.id = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString();
                form.cinC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[3].Value.ToString();
                form.nomC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[4].Value.ToString();
                form.prenomC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[5].Value.ToString();
                form.dateNaissC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[6].Value.ToString();
                form.adresseC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[7].Value.ToString();
                form.telephoneC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[8].Value.ToString();
                form.CategorieC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[9].Value.ToString();
                form.typeinscriptionC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[10].Value.ToString();
                form.situationC = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[11].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
                Console.WriteLine(form.id);
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("étez-vous sur de supprimer ce moniteur?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBCandidat.deleteCandidat(MoniteurDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

    }
}
