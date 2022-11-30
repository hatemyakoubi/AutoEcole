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
                form.dateRecM = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[9].Value.ToString();
                form.congeM = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[10].Value.ToString();
                form.salaireM = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[11].Value.ToString();
                form.ribM = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[12].Value.ToString();
                form.cnssM = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[13].Value.ToString();
                form.posteM = MoniteurDataGridView.Rows[e.ColumnIndex].Cells[14].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
                Console.WriteLine(form.id);
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("étez-vous sur de supprimer ce personnel?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBMoniteur.deletePersonnel(MoniteurDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString());
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
