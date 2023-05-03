using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gestiondeappartement.Modèle;

namespace gestiondeappartement
{
    public partial class Modifier : Form
    {
        private Appartements selectedAppartement;

        public Modifier(Appartements selectedAppartement)
        {
            this.selectedAppartement = selectedAppartement;
            InitializeComponent();
            RemplirTextBox();
        }

        private void RemplirTextBox()
    {
        txtNumAppart.Text = selectedAppartement.GetNumAppart().ToString();
        txtTypeAppart.Text = selectedAppartement.GetTypappart();
        txtPrixLoc.Text = selectedAppartement.GetPrixLoc().ToString();
        txtPrixCharge.Text = selectedAppartement.GetPrixCharg().ToString();
        txtRue.Text = selectedAppartement.GetRue();
        txtArrondissement.Text = selectedAppartement.GetArrondissement().ToString();
        txtEtage.Text = selectedAppartement.GetEtage().ToString();
        txtAscenseur.Text = selectedAppartement.GetAscenceur().ToString();
        txtPreavis.Text = selectedAppartement.GetPreavis().ToString();
        DTPDATE.Value = selectedAppartement.GetDateLibre();
        txtNumProp.Text = selectedAppartement.GetNumprop().ToString();
        txtNumLoc.Text = selectedAppartement.GetNumloc().ToString();
    }

         private void btnPanierRetour_Click(object sender, EventArgs e)
         {
            this.Close();
         }

        private void btnPanierSupprimer_Click(object sender, EventArgs e)
        {
        
        }

        private void btnPaiement_Click(object sender, EventArgs e)
        {
            int numappart = int.Parse(txtNumAppart.Text);
            string typappart = txtTypeAppart.Text;
            decimal prixLoc = decimal.Parse(txtPrixLoc.Text);
            decimal prixCharg = decimal.Parse(txtPrixCharge.Text);
            string rue = txtRue.Text;
            int arrondissement = int.Parse(txtArrondissement.Text);
            int etage = int.Parse(txtEtage.Text);
            int ascenseur = int.Parse(txtAscenseur.Text);
            int preavis = int.Parse(txtPreavis.Text);
            DateTime dateLibre = DTPDATE.Value.Date;
            int numeroprop = int.Parse(txtNumProp.Text);
            int numeroloc = int.Parse(txtNumLoc.Text);

            bool success = AppartementDAO.ModifierAppartement(numappart, typappart, prixLoc, prixCharg, rue, arrondissement, etage, ascenseur, preavis, dateLibre, numeroprop, numeroloc);

            if (success)
            {
                MessageBox.Show("Appartement modifié avec succès !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'appartement.");
            }
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {

        }

        private void ListPanier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet appartement?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (AppartementDAO.SupprimerAppartement(selectedAppartement.GetNumAppart()))
                {
                    MessageBox.Show("L'appartement a été supprimé avec succès.", "Suppression réussie");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de l'appartement.", "Erreur de suppression");
                }
            }

        }
    }
}
