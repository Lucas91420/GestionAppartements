
namespace gestiondeappartement
{
    partial class ConnexionFRM
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
            this.groupboxConnexion = new System.Windows.Forms.GroupBox();
            this.lblConnexionSI = new System.Windows.Forms.Label();
            this.lblIncorrecteConnexion = new System.Windows.Forms.Label();
            this.btnEffacerSi = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblpasswordSi = new System.Windows.Forms.Label();
            this.btnFormulaireSI = new System.Windows.Forms.Button();
            this.lblemailSi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxConnexion
            // 
            this.groupboxConnexion.Controls.Add(this.label1);
            this.groupboxConnexion.Controls.Add(this.lblConnexionSI);
            this.groupboxConnexion.Controls.Add(this.lblIncorrecteConnexion);
            this.groupboxConnexion.Controls.Add(this.btnEffacerSi);
            this.groupboxConnexion.Controls.Add(this.txtNom);
            this.groupboxConnexion.Controls.Add(this.txtPrenom);
            this.groupboxConnexion.Controls.Add(this.lblpasswordSi);
            this.groupboxConnexion.Controls.Add(this.btnFormulaireSI);
            this.groupboxConnexion.Controls.Add(this.lblemailSi);
            this.groupboxConnexion.Controls.Add(this.label6);
            this.groupboxConnexion.Location = new System.Drawing.Point(12, 79);
            this.groupboxConnexion.Name = "groupboxConnexion";
            this.groupboxConnexion.Size = new System.Drawing.Size(1044, 462);
            this.groupboxConnexion.TabIndex = 5;
            this.groupboxConnexion.TabStop = false;
            this.groupboxConnexion.Text = "Connexion";
            // 
            // lblConnexionSI
            // 
            this.lblConnexionSI.AutoSize = true;
            this.lblConnexionSI.BackColor = System.Drawing.Color.Teal;
            this.lblConnexionSI.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConnexionSI.ForeColor = System.Drawing.Color.Honeydew;
            this.lblConnexionSI.Location = new System.Drawing.Point(480, 13);
            this.lblConnexionSI.Name = "lblConnexionSI";
            this.lblConnexionSI.Size = new System.Drawing.Size(132, 35);
            this.lblConnexionSI.TabIndex = 14;
            this.lblConnexionSI.Text = "Connexion";
            // 
            // lblIncorrecteConnexion
            // 
            this.lblIncorrecteConnexion.AutoSize = true;
            this.lblIncorrecteConnexion.Location = new System.Drawing.Point(250, 330);
            this.lblIncorrecteConnexion.Name = "lblIncorrecteConnexion";
            this.lblIncorrecteConnexion.Size = new System.Drawing.Size(0, 20);
            this.lblIncorrecteConnexion.TabIndex = 13;
            // 
            // btnEffacerSi
            // 
            this.btnEffacerSi.BackColor = System.Drawing.Color.Teal;
            this.btnEffacerSi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEffacerSi.ForeColor = System.Drawing.Color.White;
            this.btnEffacerSi.Location = new System.Drawing.Point(901, 401);
            this.btnEffacerSi.Name = "btnEffacerSi";
            this.btnEffacerSi.Size = new System.Drawing.Size(137, 55);
            this.btnEffacerSi.TabIndex = 12;
            this.btnEffacerSi.Text = "Effacer";
            this.btnEffacerSi.UseVisualStyleBackColor = false;
            this.btnEffacerSi.Click += new System.EventHandler(this.btnEffacerSi_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(300, 128);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(484, 27);
            this.txtNom.TabIndex = 11;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(300, 263);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(484, 27);
            this.txtPrenom.TabIndex = 10;
            // 
            // lblpasswordSi
            // 
            this.lblpasswordSi.AutoSize = true;
            this.lblpasswordSi.Location = new System.Drawing.Point(211, 266);
            this.lblpasswordSi.Name = "lblpasswordSi";
            this.lblpasswordSi.Size = new System.Drawing.Size(67, 20);
            this.lblpasswordSi.TabIndex = 9;
            this.lblpasswordSi.Text = "Prenom :";
            // 
            // btnFormulaireSI
            // 
            this.btnFormulaireSI.BackColor = System.Drawing.Color.Teal;
            this.btnFormulaireSI.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormulaireSI.ForeColor = System.Drawing.Color.White;
            this.btnFormulaireSI.Location = new System.Drawing.Point(446, 318);
            this.btnFormulaireSI.Name = "btnFormulaireSI";
            this.btnFormulaireSI.Size = new System.Drawing.Size(207, 55);
            this.btnFormulaireSI.TabIndex = 6;
            this.btnFormulaireSI.Text = "Connexion ";
            this.btnFormulaireSI.UseVisualStyleBackColor = false;
            this.btnFormulaireSI.Click += new System.EventHandler(this.btnFormulaireSI_Click);
            // 
            // lblemailSi
            // 
            this.lblemailSi.AutoSize = true;
            this.lblemailSi.Location = new System.Drawing.Point(229, 128);
            this.lblemailSi.Name = "lblemailSi";
            this.lblemailSi.Size = new System.Drawing.Size(49, 20);
            this.lblemailSi.TabIndex = 8;
            this.lblemailSi.Text = "Nom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Teal;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(16, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(120, 45);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Home";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // ConnexionFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1068, 553);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.groupboxConnexion);
            this.Name = "ConnexionFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FrmFormulaire_Load);
            this.groupboxConnexion.ResumeLayout(false);
            this.groupboxConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupboxConnexion;
        private System.Windows.Forms.Button btnFormulaireSI;
        private System.Windows.Forms.Label lblemailSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpasswordSi;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnEffacerSi;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblIncorrecteConnexion;
        private System.Windows.Forms.Label lblConnexionSI;
        private System.Windows.Forms.Label label1;
    }
}