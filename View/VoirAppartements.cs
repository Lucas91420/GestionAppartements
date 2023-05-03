using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using gestiondeappartement.Modèle;
using gestiondeappartement.Controller;

namespace gestiondeappartement
{
    public partial class VoirAppartements : Form
    {
        public VoirAppartements()
        {
            InitializeComponent();
        
        }
        public void AfficherAppartementsProprietaire(List<Appartements> appartements)
        {
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
            
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {

        }

        private void ListPanier_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroprop = Users_Controller.GlobalVariables.UtilisateurConnecte.numeroprop;
            MessageBox.Show($"Numéro de propriétaire: {numeroprop}");
            List<Appartements> appartements = ProprietaireDAO.GetAppartementsByNumeroProp(numeroprop);

          

            // Effacer le contenu de la ListBox
            ListVoirMesAppartements.Items.Clear();

            // Parcourir la liste d'appartements et ajouter chaque appartement à la ListBox
            foreach (Appartements appartement in appartements)
            {
                ListVoirMesAppartements.Items.Add(appartement.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListVoirMesAppartements.SelectedItem != null)
            {
                Appartements selectedAppartement = (Appartements)ListVoirMesAppartements.SelectedItem;

                Modifier modifierForm = new Modifier(selectedAppartement);

                if (modifierForm.ShowDialog() == DialogResult.OK)
                {
                    // Si la modification a été validée, on met à jour la liste des appartements
                    ListVoirMesAppartements.DataSource = null;
                    ListVoirMesAppartements.DataSource = AppartementDAO.LesAppartements;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un appartement à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ConnexionDB.ConnexionBdd();
            Appartements a = (Appartements)ListVoirMesAppartements.SelectedItem;
            if (a == null)
            {
                MessageBox.Show("Veuillez selectionné un appartement a supprimer");
            }
            else
            {
                bool estdelete = AppartementDAO.SupprimerAppartement(a.GetNumAppart());
                if (estdelete)
                {
                    Appartements b = (Appartements)ListVoirMesAppartements.SelectedItem;
                    if (ListVoirMesAppartements.SelectedIndex > -1)
                        ListVoirMesAppartements.Items.RemoveAt(ListVoirMesAppartements.SelectedIndex);
                    else
                        MessageBox.Show("Veuillez selectionné un appartement a supprimer");
                }
                else
                {
                    MessageBox.Show("Cet appartement a été supprimé");
                }
            }
        }
    }
}
