
namespace gestiondeappartement
{
    partial class Demande
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateLimite = new System.Windows.Forms.DateTimePicker();
            this.txtArrondissement = new System.Windows.Forms.TextBox();
            this.txtTypeDem = new System.Windows.Forms.TextBox();
            this.txtNumDem = new System.Windows.Forms.TextBox();
            this.btnEnregistrerFormulaire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListDemandes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnbjours = new System.Windows.Forms.TextBox();
            this.dtpdatedebut = new System.Windows.Forms.DateTimePicker();
            this.dtpdatefin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Arrondissement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type de demande ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 26;
            // 
            // dtpDateLimite
            // 
            this.dtpDateLimite.Location = new System.Drawing.Point(12, 383);
            this.dtpDateLimite.Name = "dtpDateLimite";
            this.dtpDateLimite.Size = new System.Drawing.Size(255, 27);
            this.dtpDateLimite.TabIndex = 25;
            // 
            // txtArrondissement
            // 
            this.txtArrondissement.Location = new System.Drawing.Point(51, 303);
            this.txtArrondissement.Name = "txtArrondissement";
            this.txtArrondissement.Size = new System.Drawing.Size(151, 27);
            this.txtArrondissement.TabIndex = 24;
            // 
            // txtTypeDem
            // 
            this.txtTypeDem.Location = new System.Drawing.Point(51, 215);
            this.txtTypeDem.Name = "txtTypeDem";
            this.txtTypeDem.Size = new System.Drawing.Size(151, 27);
            this.txtTypeDem.TabIndex = 23;
            // 
            // txtNumDem
            // 
            this.txtNumDem.Location = new System.Drawing.Point(51, 136);
            this.txtNumDem.Name = "txtNumDem";
            this.txtNumDem.Size = new System.Drawing.Size(151, 27);
            this.txtNumDem.TabIndex = 22;
            // 
            // btnEnregistrerFormulaire
            // 
            this.btnEnregistrerFormulaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnregistrerFormulaire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnregistrerFormulaire.Location = new System.Drawing.Point(36, 12);
            this.btnEnregistrerFormulaire.Name = "btnEnregistrerFormulaire";
            this.btnEnregistrerFormulaire.Size = new System.Drawing.Size(177, 45);
            this.btnEnregistrerFormulaire.TabIndex = 21;
            this.btnEnregistrerFormulaire.Text = "Enregistrer";
            this.btnEnregistrerFormulaire.UseVisualStyleBackColor = true;
            this.btnEnregistrerFormulaire.Click += new System.EventHandler(this.btnEnregistrerFormulaire_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(728, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 29;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(276, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 45);
            this.button2.TabIndex = 30;
            this.button2.Text = "Afficher ses demandes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListDemandes
            // 
            this.ListDemandes.FormattingEnabled = true;
            this.ListDemandes.ItemHeight = 20;
            this.ListDemandes.Location = new System.Drawing.Point(276, 115);
            this.ListDemandes.Name = "ListDemandes";
            this.ListDemandes.Size = new System.Drawing.Size(637, 204);
            this.ListDemandes.TabIndex = 31;
            this.ListDemandes.SelectedIndexChanged += new System.EventHandler(this.ListDemandes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Numéro de demande";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(552, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 45);
            this.button3.TabIndex = 33;
            this.button3.Text = "Supprimer sa demande";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(552, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 45);
            this.button4.TabIndex = 34;
            this.button4.Text = "Modifier ma demande";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Date Limite";
            // 
            // txtnbjours
            // 
            this.txtnbjours.Location = new System.Drawing.Point(459, 411);
            this.txtnbjours.Name = "txtnbjours";
            this.txtnbjours.Size = new System.Drawing.Size(151, 27);
            this.txtnbjours.TabIndex = 36;
            this.txtnbjours.TextChanged += new System.EventHandler(this.txtnbjours_TextChanged);
            // 
            // dtpdatedebut
            // 
            this.dtpdatedebut.Location = new System.Drawing.Point(276, 355);
            this.dtpdatedebut.Name = "dtpdatedebut";
            this.dtpdatedebut.Size = new System.Drawing.Size(255, 27);
            this.dtpdatedebut.TabIndex = 37;
            // 
            // dtpdatefin
            // 
            this.dtpdatefin.Location = new System.Drawing.Point(550, 355);
            this.dtpdatefin.Name = "dtpdatefin";
            this.dtpdatefin.Size = new System.Drawing.Size(255, 27);
            this.dtpdatefin.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nombre de jours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Date de fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Date de début";
            // 
            // Demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpdatefin);
            this.Controls.Add(this.dtpdatedebut);
            this.Controls.Add(this.txtnbjours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListDemandes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateLimite);
            this.Controls.Add(this.txtArrondissement);
            this.Controls.Add(this.txtTypeDem);
            this.Controls.Add(this.txtNumDem);
            this.Controls.Add(this.btnEnregistrerFormulaire);
            this.Name = "Demande";
            this.Text = "Demande";
            this.Load += new System.EventHandler(this.FormPanier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateLimite;
        private System.Windows.Forms.TextBox txtArrondissement;
        private System.Windows.Forms.TextBox txtTypeDem;
        private System.Windows.Forms.TextBox txtNumDem;
        private System.Windows.Forms.Button btnEnregistrerFormulaire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListDemandes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnbjours;
        private System.Windows.Forms.DateTimePicker dtpdatedebut;
        private System.Windows.Forms.DateTimePicker dtpdatefin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}