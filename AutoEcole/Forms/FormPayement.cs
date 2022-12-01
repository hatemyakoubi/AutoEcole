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
            if (e.ColumnIndex == 0)
            {
                //edit
                form.ClearField();
                form.id = PayementDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString();
                form.montantC = PayementDataGridView.Rows[e.ColumnIndex].Cells[3].Value.ToString();
                form.cinC = PayementDataGridView.Rows[e.ColumnIndex].Cells[4].Value.ToString();
                form.nomC = PayementDataGridView.Rows[e.ColumnIndex].Cells[5].Value.ToString();
                //form.datePayement = PayementDataGridView.Rows[e.ColumnIndex].Cells[].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
                Console.WriteLine(form.id);
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("étez-vous sur de supprimer ce payement?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBPayement.deletePayement(PayementDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.ClearField();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBPayement.DisplayAndSearchPayement("select idPayement,montant,cinCandidat,nomCandidat,datePayement FROM payement WHERE nom LIKE'%" + txtSearch.Text + "%' ", PayementDataGridView);
        }

        private void FormPayement_Shown(object sender, EventArgs e)
        {
            Display();
        }

    }
}
