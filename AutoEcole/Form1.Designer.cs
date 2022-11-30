
namespace AutoEcole
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVehicule = new System.Windows.Forms.Button();
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnPayement = new System.Windows.Forms.Button();
            this.btnExamen = new System.Windows.Forms.Button();
            this.btnSeance = new System.Windows.Forms.Button();
            this.btnMoniteurs = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseT = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnVehicule);
            this.panelMenu.Controls.Add(this.btnParametre);
            this.panelMenu.Controls.Add(this.btnPayement);
            this.panelMenu.Controls.Add(this.btnExamen);
            this.panelMenu.Controls.Add(this.btnSeance);
            this.panelMenu.Controls.Add(this.btnMoniteurs);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 530);
            this.panelMenu.TabIndex = 0;
            // 
            // btnVehicule
            // 
            this.btnVehicule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicule.FlatAppearance.BorderSize = 0;
            this.btnVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicule.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVehicule.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicule.Image")));
            this.btnVehicule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicule.Location = new System.Drawing.Point(0, 440);
            this.btnVehicule.Name = "btnVehicule";
            this.btnVehicule.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVehicule.Size = new System.Drawing.Size(221, 60);
            this.btnVehicule.TabIndex = 7;
            this.btnVehicule.Text = "Véhicule";
            this.btnVehicule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicule.UseVisualStyleBackColor = true;
            this.btnVehicule.Click += new System.EventHandler(this.btnMoniteur_Click);
            // 
            // btnParametre
            // 
            this.btnParametre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametre.FlatAppearance.BorderSize = 0;
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParametre.Image = ((System.Drawing.Image)(resources.GetObject("btnParametre.Image")));
            this.btnParametre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametre.Location = new System.Drawing.Point(0, 380);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnParametre.Size = new System.Drawing.Size(221, 60);
            this.btnParametre.TabIndex = 6;
            this.btnParametre.Text = " Paramètres";
            this.btnParametre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametre.UseVisualStyleBackColor = true;
            this.btnParametre.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPayement
            // 
            this.btnPayement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayement.FlatAppearance.BorderSize = 0;
            this.btnPayement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayement.Image = ((System.Drawing.Image)(resources.GetObject("btnPayement.Image")));
            this.btnPayement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayement.Location = new System.Drawing.Point(0, 320);
            this.btnPayement.Name = "btnPayement";
            this.btnPayement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPayement.Size = new System.Drawing.Size(221, 60);
            this.btnPayement.TabIndex = 5;
            this.btnPayement.Text = " Payements";
            this.btnPayement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayement.UseVisualStyleBackColor = true;
            this.btnPayement.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExamen
            // 
            this.btnExamen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExamen.FlatAppearance.BorderSize = 0;
            this.btnExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExamen.Image = ((System.Drawing.Image)(resources.GetObject("btnExamen.Image")));
            this.btnExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamen.Location = new System.Drawing.Point(0, 260);
            this.btnExamen.Name = "btnExamen";
            this.btnExamen.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExamen.Size = new System.Drawing.Size(221, 60);
            this.btnExamen.TabIndex = 4;
            this.btnExamen.Text = " Examens";
            this.btnExamen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExamen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExamen.UseVisualStyleBackColor = true;
            this.btnExamen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSeance
            // 
            this.btnSeance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeance.FlatAppearance.BorderSize = 0;
            this.btnSeance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeance.Image = ((System.Drawing.Image)(resources.GetObject("btnSeance.Image")));
            this.btnSeance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeance.Location = new System.Drawing.Point(0, 200);
            this.btnSeance.Name = "btnSeance";
            this.btnSeance.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSeance.Size = new System.Drawing.Size(221, 60);
            this.btnSeance.TabIndex = 3;
            this.btnSeance.Text = " Séances";
            this.btnSeance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeance.UseVisualStyleBackColor = true;
            this.btnSeance.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMoniteurs
            // 
            this.btnMoniteurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoniteurs.FlatAppearance.BorderSize = 0;
            this.btnMoniteurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoniteurs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMoniteurs.Image = ((System.Drawing.Image)(resources.GetObject("btnMoniteurs.Image")));
            this.btnMoniteurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoniteurs.Location = new System.Drawing.Point(0, 140);
            this.btnMoniteurs.Name = "btnMoniteurs";
            this.btnMoniteurs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMoniteurs.Size = new System.Drawing.Size(221, 60);
            this.btnMoniteurs.TabIndex = 2;
            this.btnMoniteurs.Text = "Personnels";
            this.btnMoniteurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoniteurs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoniteurs.UseVisualStyleBackColor = true;
            this.btnMoniteurs.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 80);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(221, 60);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = " Candidats";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(221, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DevProd Solution";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnCloseT);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(221, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(876, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(771, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "-";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(807, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseT
            // 
            this.btnCloseT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseT.FlatAppearance.BorderSize = 0;
            this.btnCloseT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseT.ForeColor = System.Drawing.Color.White;
            this.btnCloseT.Location = new System.Drawing.Point(843, 0);
            this.btnCloseT.Name = "btnCloseT";
            this.btnCloseT.Size = new System.Drawing.Size(30, 30);
            this.btnCloseT.TabIndex = 2;
            this.btnCloseT.Text = "x";
            this.btnCloseT.UseVisualStyleBackColor = true;
            this.btnCloseT.Click += new System.EventHandler(this.btnCloseT_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 80);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(336, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ACCEUIL";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(221, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(876, 450);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 530);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Form1";
            this.Text = "Swift Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPayement;
        private System.Windows.Forms.Button btnExamen;
        private System.Windows.Forms.Button btnSeance;
        private System.Windows.Forms.Button btnMoniteurs;
        private System.Windows.Forms.Button btnParametre;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseT;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnVehicule;
    }
}

