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
    public partial class FormPayement : Form
    {
        NewPayement form;
        int indexRow;
        public FormPayement()
        {
            InitializeComponent();
            LoadTheme();
            form = new NewPayement(this);
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
            DBPayement.DisplayAndSearchPayement("SELECT idPayement,montant,cinCandidat,nomCandidat,datePayement FROM payement", PayementDataGridView);
        }

        private void PayementDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            indexRow = e.RowIndex;
            DataGridViewRow row = PayementDataGridView.Rows[indexRow];
            connexion.id= row.Cells[0].Value.ToString();
            connexion.montant = row.Cells[1].Value.ToString();
            connexion.cin = row.Cells[2].Value.ToString();
            connexion.nom = row.Cells[3].Value.ToString();
            form.updateInfo();
            form.ShowDialog();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBPayement.DisplayAndSearchPayement("select idPayement,montant,cinCandidat,nomCandidat,datePayement FROM payement WHERE nomCandidat LIKE'%" + txtSearch.Text + "%' ", PayementDataGridView);
        }

        private void FormPayement_Shown(object sender, EventArgs e)
        {
            Display();
        }

    }
}
