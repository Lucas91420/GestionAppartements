
namespace gestiondeappartement
{
    partial class Consulter
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnQuitterEnregistrer = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnConsuAppart = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSupprimerAppart = new System.Windows.Forms.Button();
            this.btnCategoPanier = new System.Windows.Forms.Button();
            this.btnVoirPanier = new System.Windows.Forms.Button();
            this.ListAppartements = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnQuitterEnregistrer);
            this.panel1.Controls.Add(this.txtRecherche);
            this.panel1.Controls.Add(this.btnConsuAppart);
            this.panel1.Controls.Add(this.btnEnregistrer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 129);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(219, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(588, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Rechercher par arrondissement/type appart/prix location";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuitterEnregistrer
            // 
            this.btnQuitterEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitterEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitterEnregistrer.Location = new System.Drawing.Point(12, 5);
            this.btnQuitterEnregistrer.Name = "btnQuitterEnregistrer";
            this.btnQuitterEnregistrer.Size = new System.Drawing.Size(88, 39);
            this.btnQuitterEnregistrer.TabIndex = 9;
            this.btnQuitterEnregistrer.Text = "Quitter";
            this.btnQuitterEnregistrer.UseVisualStyleBackColor = true;
            this.btnQuitterEnregistrer.Click += new System.EventHandler(this.btnQuitterEnregistrer_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(399, 50);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(174, 27);
            this.txtRecherche.TabIndex = 7;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // btnConsuAppart
            // 
            this.btnConsuAppart.BackColor = System.Drawing.Color.Teal;
            this.btnConsuAppart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsuAppart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsuAppart.Location = new System.Drawing.Point(679, 55);
            this.btnConsuAppart.Name = "btnConsuAppart";
            this.btnConsuAppart.Size = new System.Drawing.Size(248, 71);
            this.btnConsuAppart.TabIndex = 5;
            this.btnConsuAppart.Text = "Consulter Appartements";
            this.btnConsuAppart.UseVisualStyleBackColor = false;
            this.btnConsuAppart.Click += new System.EventHandler(this.btnConsuAppart_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Teal;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 55);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(236, 71);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer un appartement";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(436, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimerAppart
            // 
            this.btnSupprimerAppart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerAppart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerAppart.Location = new System.Drawing.Point(219, 424);
            this.btnSupprimerAppart.Name = "btnSupprimerAppart";
            this.btnSupprimerAppart.Size = new System.Drawing.Size(193, 47);
            this.btnSupprimerAppart.TabIndex = 8;
            this.btnSupprimerAppart.Text = "Supprimer";
            this.btnSupprimerAppart.UseVisualStyleBackColor = true;
            this.btnSupprimerAppart.Click += new System.EventHandler(this.btnSupprimerAppart_Click);
            // 
            // btnCategoPanier
            // 
            this.btnCategoPanier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategoPanier.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategoPanier.Location = new System.Drawing.Point(12, 426);
            this.btnCategoPanier.Name = "btnCategoPanier";
            this.btnCategoPanier.Size = new System.Drawing.Size(193, 45);
            this.btnCategoPanier.TabIndex = 2;
            this.btnCategoPanier.Text = "Faire une demande";
            this.btnCategoPanier.UseVisualStyleBackColor = true;
            this.btnCategoPanier.Click += new System.EventHandler(this.btnCategoPanier_Click);
            // 
            // btnVoirPanier
            // 
            this.btnVoirPanier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoirPanier.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoirPanier.Location = new System.Drawing.Point(647, 424);
            this.btnVoirPanier.Name = "btnVoirPanier";
            this.btnVoirPanier.Size = new System.Drawing.Size(233, 47);
            this.btnVoirPanier.TabIndex = 6;
            this.btnVoirPanier.Text = "Visiter cet appartement";
            this.btnVoirPanier.UseVisualStyleBackColor = true;
            this.btnVoirPanier.Click += new System.EventHandler(this.btnVoirPanier_Click);
            // 
            // ListAppartements
            // 
            this.ListAppartements.BackColor = System.Drawing.Color.White;
            this.ListAppartements.FormattingEnabled = true;
            this.ListAppartements.HorizontalScrollbar = true;
            this.ListAppartements.ItemHeight = 20;
            this.ListAppartements.Location = new System.Drawing.Point(12, 135);
            this.ListAppartements.Name = "ListAppartements";
            this.ListAppartements.Size = new System.Drawing.Size(917, 284);
            this.ListAppartements.TabIndex = 7;
            this.ListAppartements.SelectedIndexChanged += new System.EventHandler(this.ListAppartements_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(262, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(411, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Afficher les appartements à courte durée";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(932, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCategoPanier);
            this.Controls.Add(this.btnSupprimerAppart);
            this.Controls.Add(this.ListAppartements);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoirPanier);
            this.Name = "Consulter";
            this.Text = "Consulter";
            this.Load += new System.EventHandler(this.Consulter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnCategoPanier;
        private System.Windows.Forms.Button btnVoirPanier;
        private System.Windows.Forms.Button btnConsuAppart;
        private System.Windows.Forms.ListBox ListAppartements;
        private System.Windows.Forms.Button btnSupprimerAppart;
        private System.Windows.Forms.Button btnQuitterEnregistrer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}