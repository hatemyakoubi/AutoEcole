
namespace AutoEcole.Forms
{
    partial class FormSeance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SeanceDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeSeance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCandidat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePayement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moniteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SeanceDataGridView);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 496);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(777, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(27, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // SeanceDataGridView
            // 
            this.SeanceDataGridView.AllowUserToAddRows = false;
            this.SeanceDataGridView.AllowUserToDeleteRows = false;
            this.SeanceDataGridView.AllowUserToResizeColumns = false;
            this.SeanceDataGridView.AllowUserToResizeRows = false;
            this.SeanceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeanceDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SeanceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SeanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.typeSeance,
            this.nomCandidat,
            this.datePayement,
            this.moniteur,
            this.Column7,
            this.Column8});
            this.SeanceDataGridView.GridColor = System.Drawing.Color.White;
            this.SeanceDataGridView.Location = new System.Drawing.Point(27, 86);
            this.SeanceDataGridView.MultiSelect = false;
            this.SeanceDataGridView.Name = "SeanceDataGridView";
            this.SeanceDataGridView.ReadOnly = true;
            this.SeanceDataGridView.RowHeadersVisible = false;
            this.SeanceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SeanceDataGridView.ShowEditingIcon = false;
            this.SeanceDataGridView.Size = new System.Drawing.Size(987, 399);
            this.SeanceDataGridView.TabIndex = 3;
            this.SeanceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeanceDataGridView_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::AutoEcole.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(973, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "idSeance";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // typeSeance
            // 
            this.typeSeance.DataPropertyName = "type_seance";
            this.typeSeance.HeaderText = "Type Séance";
            this.typeSeance.Name = "typeSeance";
            this.typeSeance.ReadOnly = true;
            // 
            // nomCandidat
            // 
            this.nomCandidat.DataPropertyName = "nomCandidat";
            this.nomCandidat.HeaderText = "Nom & Prénom";
            this.nomCandidat.Name = "nomCandidat";
            this.nomCandidat.ReadOnly = true;
            // 
            // datePayement
            // 
            this.datePayement.DataPropertyName = "dateSeance";
            this.datePayement.HeaderText = "Date séance";
            this.datePayement.Name = "datePayement";
            this.datePayement.ReadOnly = true;
            // 
            // moniteur
            // 
            this.moniteur.DataPropertyName = "moniteur";
            this.moniteur.HeaderText = "Moniteur";
            this.moniteur.Name = "moniteur";
            this.moniteur.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Modifier";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Supprimer";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // FormSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 499);
            this.Controls.Add(this.panel1);
            this.Name = "FormSeance";
            this.Text = "Gestion des séances";
            this.Shown += new System.EventHandler(this.FormSeance_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView SeanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeSeance;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCandidat;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePayement;
        private System.Windows.Forms.DataGridViewTextBoxColumn moniteur;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}