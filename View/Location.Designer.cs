
namespace gestiondeappartement
{
    partial class FormLoc
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
            this.btnPanierSupprimer = new System.Windows.Forms.Button();
            this.btnPanierRetour = new System.Windows.Forms.Button();
            this.btnPaiement = new System.Windows.Forms.Button();
            this.ListChoixAppartements = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListVisites = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpVisite = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnPanierSupprimer
            // 
            this.btnPanierSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanierSupprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPanierSupprimer.Location = new System.Drawing.Point(669, 87);
            this.btnPanierSupprimer.Name = "btnPanierSupprimer";
            this.btnPanierSupprimer.Size = new System.Drawing.Size(234, 56);
            this.btnPanierSupprimer.TabIndex = 1;
            this.btnPanierSupprimer.Text = "Supprimer";
            this.btnPanierSupprimer.UseVisualStyleBackColor = true;
            this.btnPanierSupprimer.Click += new System.EventHandler(this.btnPanierSupprimer_Click);
            // 
            // btnPanierRetour
            // 
            this.btnPanierRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanierRetour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPanierRetour.Location = new System.Drawing.Point(757, 384);
            this.btnPanierRetour.Name = "btnPanierRetour";
            this.btnPanierRetour.Size = new System.Drawing.Size(148, 54);
            this.btnPanierRetour.TabIndex = 2;
            this.btnPanierRetour.Text = "Retour";
            this.btnPanierRetour.UseVisualStyleBackColor = true;
            this.btnPanierRetour.Click += new System.EventHandler(this.btnPanierRetour_Click);
            // 
            // btnPaiement
            // 
            this.btnPaiement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaiement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaiement.Location = new System.Drawing.Point(669, 12);
            this.btnPaiement.Name = "btnPaiement";
            this.btnPaiement.Size = new System.Drawing.Size(234, 54);
            this.btnPaiement.TabIndex = 3;
            this.btnPaiement.Text = "Devenir Locataire";
            this.btnPaiement.UseVisualStyleBackColor = true;
            this.btnPaiement.Click += new System.EventHandler(this.btnPaiement_Click);
            // 
            // ListChoixAppartements
            // 
            this.ListChoixAppartements.FormattingEnabled = true;
            this.ListChoixAppartements.HorizontalScrollbar = true;
            this.ListChoixAppartements.ItemHeight = 20;
            this.ListChoixAppartements.Location = new System.Drawing.Point(12, 2);
            this.ListChoixAppartements.Name = "ListChoixAppartements";
            this.ListChoixAppartements.Size = new System.Drawing.Size(610, 164);
            this.ListChoixAppartements.TabIndex = 4;
            this.ListChoixAppartements.SelectedIndexChanged += new System.EventHandler(this.ListPanier_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(669, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter une visite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListVisites
            // 
            this.ListVisites.FormattingEnabled = true;
            this.ListVisites.HorizontalScrollbar = true;
            this.ListVisites.ItemHeight = 20;
            this.ListVisites.Location = new System.Drawing.Point(12, 183);
            this.ListVisites.Name = "ListVisites";
            this.ListVisites.Size = new System.Drawing.Size(610, 184);
            this.ListVisites.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(669, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Afficher ses visites";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpVisite
            // 
            this.dtpVisite.Location = new System.Drawing.Point(650, 226);
            this.dtpVisite.Name = "dtpVisite";
            this.dtpVisite.Size = new System.Drawing.Size(253, 27);
            this.dtpVisite.TabIndex = 8;
            // 
            // FormLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.dtpVisite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListVisites);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListChoixAppartements);
            this.Controls.Add(this.btnPaiement);
            this.Controls.Add(this.btnPanierSupprimer);
            this.Controls.Add(this.btnPanierRetour);
            this.Name = "FormLoc";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.FormPanier_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPanierSupprimer;
        private System.Windows.Forms.Button btnPanierRetour;
        private System.Windows.Forms.Button btnPaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ListBox ListChoixAppartements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListVisites;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpVisite;
    }
}