
namespace gestiondeappartement
{
    partial class VoirLocation
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
            this.ListLocation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPanierSupprimer
            // 
            this.btnPanierSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanierSupprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPanierSupprimer.Location = new System.Drawing.Point(736, 87);
            this.btnPanierSupprimer.Name = "btnPanierSupprimer";
            this.btnPanierSupprimer.Size = new System.Drawing.Size(167, 56);
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
            this.btnPaiement.Location = new System.Drawing.Point(736, 12);
            this.btnPaiement.Name = "btnPaiement";
            this.btnPaiement.Size = new System.Drawing.Size(167, 69);
            this.btnPaiement.TabIndex = 3;
            this.btnPaiement.Text = "Voir ma Location";
            this.btnPaiement.UseVisualStyleBackColor = true;
            this.btnPaiement.Click += new System.EventHandler(this.btnPaiement_Click);
            // 
            // ListLocation
            // 
            this.ListLocation.FormattingEnabled = true;
            this.ListLocation.HorizontalScrollbar = true;
            this.ListLocation.ItemHeight = 20;
            this.ListLocation.Location = new System.Drawing.Point(12, 68);
            this.ListLocation.Name = "ListLocation";
            this.ListLocation.Size = new System.Drawing.Size(718, 284);
            this.ListLocation.TabIndex = 4;
            this.ListLocation.SelectedIndexChanged += new System.EventHandler(this.ListPanier_SelectedIndexChanged);
            // 
            // VoirLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.ListLocation);
            this.Controls.Add(this.btnPaiement);
            this.Controls.Add(this.btnPanierSupprimer);
            this.Controls.Add(this.btnPanierRetour);
            this.Name = "VoirLocation";
            this.Text = "Form6";
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
        private System.Windows.Forms.ListBox ListLocation;
    }
}