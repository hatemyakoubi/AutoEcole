﻿using System;
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
            if (e.ColumnIndex == 0)
            {
                //edit
                form.ClearField();
                form.id = SeanceDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString();
                form.typeS = SeanceDataGridView.Rows[e.ColumnIndex].Cells[3].Value.ToString();
                form.nomC = SeanceDataGridView.Rows[e.ColumnIndex].Cells[4].Value.ToString();
                form.dateS = SeanceDataGridView.Rows[e.ColumnIndex].Cells[5].Value.ToString();
                form.moniteurS = SeanceDataGridView.Rows[e.ColumnIndex].Cells[6].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("étez-vous sur de supprimer cette séance?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBPayement.deletePayement(SeanceDataGridView.Rows[e.ColumnIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
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
