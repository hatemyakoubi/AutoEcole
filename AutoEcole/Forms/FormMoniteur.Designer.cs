
namespace AutoEcole.Forms
{
    partial class FormMoniteur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoniteurDataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrconge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoniteurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.MoniteurDataGridView);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 498);
            this.panel1.TabIndex = 1;
            // 
            // MoniteurDataGridView
            // 
            this.MoniteurDataGridView.AllowUserToAddRows = false;
            this.MoniteurDataGridView.AllowUserToDeleteRows = false;
            this.MoniteurDataGridView.AllowUserToResizeColumns = false;
            this.MoniteurDataGridView.AllowUserToResizeRows = false;
            this.MoniteurDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoniteurDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MoniteurDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MoniteurDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoniteurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoniteurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cin,
            this.nom,
            this.prenom,
            this.dateNaiss,
            this.adresse,
            this.telephone,
            this.dateRec,
            this.nbrconge,
            this.salaire,
            this.rib,
            this.cnss,
            this.role});
            this.MoniteurDataGridView.GridColor = System.Drawing.Color.White;
            this.MoniteurDataGridView.Location = new System.Drawing.Point(27, 85);
            this.MoniteurDataGridView.MultiSelect = false;
            this.MoniteurDataGridView.Name = "MoniteurDataGridView";
            this.MoniteurDataGridView.ReadOnly = true;
            this.MoniteurDataGridView.RowHeadersVisible = false;
            this.MoniteurDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MoniteurDataGridView.ShowEditingIcon = false;
            this.MoniteurDataGridView.Size = new System.Drawing.Size(995, 401);
            this.MoniteurDataGridView.TabIndex = 0;
            this.MoniteurDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoniteurDataGridView_CellClick_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(785, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::AutoEcole.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(981, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "idMoniteur";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cin
            // 
            this.cin.DataPropertyName = "cin";
            this.cin.HeaderText = "Cin";
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // dateNaiss
            // 
            this.dateNaiss.DataPropertyName = "dateNaiss";
            this.dateNaiss.HeaderText = "Dt_Naissance";
            this.dateNaiss.Name = "dateNaiss";
            this.dateNaiss.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "adresse";
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "telephone";
            this.telephone.HeaderText = "N°Tel";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // dateRec
            // 
            this.dateRec.DataPropertyName = "dateRec";
            this.dateRec.HeaderText = "Dt Rect";
            this.dateRec.Name = "dateRec";
            this.dateRec.ReadOnly = true;
            // 
            // nbrconge
            // 
            this.nbrconge.DataPropertyName = "nbrConge";
            this.nbrconge.HeaderText = "N°J.conge";
            this.nbrconge.Name = "nbrconge";
            this.nbrconge.ReadOnly = true;
            // 
            // salaire
            // 
            this.salaire.DataPropertyName = "salaire";
            this.salaire.HeaderText = "Salaire";
            this.salaire.Name = "salaire";
            this.salaire.ReadOnly = true;
            // 
            // rib
            // 
            this.rib.DataPropertyName = "rib";
            this.rib.HeaderText = "RIB";
            this.rib.Name = "rib";
            this.rib.ReadOnly = true;
            // 
            // cnss
            // 
            this.cnss.DataPropertyName = "NumCnss";
            this.cnss.HeaderText = "N°CNSS";
            this.cnss.Name = "cnss";
            this.cnss.ReadOnly = true;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // FormMoniteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 513);
            this.Controls.Add(this.panel1);
            this.Name = "FormMoniteur";
            this.Text = "liste des personnels";
            this.Shown += new System.EventHandler(this.FormMoniteur_Shown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoniteurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MoniteurDataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrconge;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn rib;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnss;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
    }
}