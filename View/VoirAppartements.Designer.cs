
namespace gestiondeappartement
{
    partial class VoirAppartements
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
            this.btnPanierRetour = new System.Windows.Forms.Button();
            this.ListVoirMesAppartements = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // ListVoirMesAppartements
            // 
            this.ListVoirMesAppartements.FormattingEnabled = true;
            this.ListVoirMesAppartements.HorizontalScrollbar = true;
            this.ListVoirMesAppartements.ItemHeight = 20;
            this.ListVoirMesAppartements.Location = new System.Drawing.Point(12, 29);
            this.ListVoirMesAppartements.Name = "ListVoirMesAppartements";
            this.ListVoirMesAppartements.Size = new System.Drawing.Size(713, 324);
            this.ListVoirMesAppartements.TabIndex = 4;
            this.ListVoirMesAppartements.SelectedIndexChanged += new System.EventHandler(this.ListPanier_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(731, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voir mon/mes apaprtements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(731, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(731, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VoirAppartements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListVoirMesAppartements);
            this.Controls.Add(this.btnPanierRetour);
            this.Name = "VoirAppartements";
            this.Text = "Voir mes appartements";
            this.Load += new System.EventHandler(this.FormPanier_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPanierRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ListBox ListVoirMesAppartements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}