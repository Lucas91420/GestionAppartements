using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestiondeappartement.Modèle;
using gestiondeappartement.Controller;
using gestiondeappartement;

namespace gestiondeappartement
{
    public partial class lblTitleChildForm : Form
    {
        /*public enum UserType
        {
            Client,
            Proprietaire,
            Locataire
        }
        */

        /*public lblTitleChildForm(UserType userType)
        {
            InitializeComponent();
            SetupButtons(userType);
        }

        private void SetupButtons(UserType userType)
        {
            switch (userType)
            {
                case UserType.Client:
                    btnInformations.Visible = true;
                    break;
                case UserType.Proprietaire:
                    btnVoirAppartement.Visible = true;
                    btnVoirLocation.Visible = false;
                    btnInformations.Visible = true;
                    btnAfficher.Visible = true;
                    break;
                case UserType.Locataire:
                    btnVoirLocation.Visible = true;
                    btnInformations.Visible = true;
                    btnVoirAppartement.Visible = false;
                    break;
            }
        }
        */
        public lblTitleChildForm()
        {
            InitializeComponent();

        }
        private bool isConnected = false;

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ConnexionFRM ConnexionFRM = new ConnexionFRM();
            ConnexionFRM.Show();
            isConnected = true;
            button1.Visible = true;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnSideMenu_Click(object sender, EventArgs e)
        {

        }


        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Consulter());
        }



        private void btnMaLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitterHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTableaudeDeBord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPaiement_Click(object sender, EventArgs e)
        {

        }

        private void btnVoirPaiement_Click(object sender, EventArgs e)
        {

        }

        private void panelBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitleChildForm_Load(object sender, EventArgs e)
        {
            btnConnexion.Visible = true;
            button1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            openChildForm(new Afficher());
        }

        private void btnMaLoction_Click(object sender, EventArgs e)
        {

        }

        private void btnVoirLocation_Click(object sender, EventArgs e)
        {
            VoirLocation VoirLocation = new VoirLocation();
            VoirLocation.Show();
        }

        private void btnInformations_Click(object sender, EventArgs e)
        {
            InfoAdherent InfoAdherent = new InfoAdherent();
            InfoAdherent.Show();
        }

        private void btnVoirAppartement_Click(object sender, EventArgs e)
        {
            VoirAppartements VoirAppartements = new VoirAppartements();
            VoirAppartements.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Réinitialiser les variables globales
            Users_Controller.GlobalVariables.UtilisateurConnecte = null;

            // Afficher un message pour indiquer que l'utilisateur a été déconnecté
            MessageBox.Show("Vous avez été déconnecté.");

            // Fermer le formulaire actuel et afficher le formulaire de connexion
            this.Hide();
            ConnexionFRM formConnexion = new ConnexionFRM();
            formConnexion.ShowDialog();
            isConnected = false;
            btnConnexion.Visible = true;
            this.Close();

        }
    }
}
