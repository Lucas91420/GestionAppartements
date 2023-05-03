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
    public partial class Consulter : Form
    {
        public Consulter()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrerFRM EnregistrerFRM = new EnregistrerFRM();
            EnregistrerFRM.Show();
        }

        private void btnCategoPanier_Click(object sender, EventArgs e)
        {
            Demande Demande = new Demande();
            Demande.Show();
        }

        private void btnVoirPanier_Click(object sender, EventArgs e)
        {
            Appartements a = (Appartements)ListAppartements.SelectedItem;
            AppartementDAO.LesAppartements.Add(a);
            FormLoc FormLoc = new FormLoc();
            FormLoc.Show();

        }

        private void btnConsuAppart_Click(object sender, EventArgs e)
        {
            ConnexionDB.ConnexionBdd();
            List<Appartements> LesAppartements = AppartementDAO.GetLesAppartements();
            ListAppartements.Items.Clear();
            ListAppartements.Items.AddRange(LesAppartements.ToArray());
        }

        private void btnSupprimerAppart_Click(object sender, EventArgs e)
        {
            ConnexionDB.ConnexionBdd();
            Appartements a = (Appartements)ListAppartements.SelectedItem;
            if (a == null)
            {
                MessageBox.Show("Veuillez selectionné un appartement a supprimer");
            }
            else
            {
                bool estdelete = AppartementDAO.SupprimerAppartement(a.GetNumAppart());
                if (estdelete)
                {
                    Appartements b = (Appartements)ListAppartements.SelectedItem;
                    if (ListAppartements.SelectedIndex > -1)
                        ListAppartements.Items.RemoveAt(ListAppartements.SelectedIndex);
                    else
                        MessageBox.Show("Veuillez selectionné un appartement a supprimer");
                }
                else
                { 
                    MessageBox.Show("Cet appartement a été supprimé");
                }
            }
        }
        private void btnQuitterEnregistrer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListAppartements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListAppartements.SelectedItem != null)
            {
                Appartements selectedAppartement = (Appartements)ListAppartements.SelectedItem;

                Modifier modifierForm = new Modifier(selectedAppartement);

                if (modifierForm.ShowDialog() == DialogResult.OK)
                {
                    // Si la modification a été validée, on met à jour la liste des appartements
                    ListAppartements.DataSource = null;
                    ListAppartements.DataSource = AppartementDAO.LesAppartements;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un appartement à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Consulter_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
      
                string recherche = txtRecherche.Text.Trim().ToLower();
                List<Appartements> resultats = new List<Appartements>();

                // Parcourir tous les appartements affichés dans la listebox
                foreach (Appartements appart in ListAppartements.Items)
                {
                    // Comparer la recherche avec les champs "TYAPPART", "ARRONDISSEMENT" et "PRIX_LOC"
                    if (appart.typappart.ToLower().Contains(recherche)
                        || appart.arrondissement.ToString().Contains(recherche)
                        || appart.prix_loc.ToString().Contains(recherche))
                    {
                        resultats.Add(appart); // Ajouter l'appartement aux résultats de la recherche
                    }
                }

                // Afficher les résultats dans la listebox
                ListAppartements.DataSource = resultats;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Appartements> appartementsCourteDuree = AppartementDAO.AfficherAppartementsCourteDuree();
            ListAppartements.Items.Clear();
            foreach (Appartements appartement in appartementsCourteDuree)
            {
                ListAppartements.Items.Add(appartement);
            }
        }
    }
}
