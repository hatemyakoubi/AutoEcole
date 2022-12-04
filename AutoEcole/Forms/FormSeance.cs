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
    public partial class FormSeance : Form
    {
        NewSeance form;
        int indexRow;
        public FormSeance()
        {
            InitializeComponent();
            LoadTheme();
            form = new NewSeance(this);
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
            DBPayement.DisplayAndSearchPayement("SELECT idSeance,type_seance,nomCandidat,dateSeance,moniteur FROM seance", SeanceDataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void SeanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = SeanceDataGridView.Rows[indexRow];
            connexion.id = row.Cells[0].Value.ToString();
            connexion.typeseance = row.Cells[1].Value.ToString();
            connexion.nom = row.Cells[2].Value.ToString();
            connexion.date = row.Cells[3].Value.ToString();
            connexion.moniteur = row.Cells[4].Value.ToString();
            form.updateInfo();
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBPayement.DisplayAndSearchPayement("select idSeance,type_seance,nomCandidat,dateSeance,moniteur FROM seance WHERE nom LIKE'%" + txtSearch.Text + "%' ", SeanceDataGridView);
        }

        private void FormSeance_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
