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
    public partial class ConnexionFRM : Form
    {
        public object CompteProprietaire;
        public object CompteClient;
        public object CompteLocataire;
        public ConnexionFRM()
        {
            InitializeComponent();
        }
        private void FrmFormulaire_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEffacerSi_Click(object sender, EventArgs e)
        {

            txtNom.Text = "";
            txtPrenom.Text = "";
        }

        private void btnFormulaireSI_Click(object sender, EventArgs e)
        {
            AdherentDAO.Adherent adherent = new AdherentDAO.Adherent();
            adherent.nom = txtNom.Text;
            adherent.prenom = txtPrenom.Text;

            CompteClient = (Client)ConnexionDB.Connexion(txtNom.Text, txtPrenom.Text);
            CompteProprietaire = (Proprietaire_modele)ConnexionDB.ConnexionProprietaire(txtNom.Text, txtPrenom.Text);
            CompteLocataire = (Locataire_modele)ConnexionDB.ConnexionLocataire(txtNom.Text, txtPrenom.Text);

            if (CompteClient != null)
            {
                adherent.TypeCompte = "Client";
                adherent.num_cli = ((Client)CompteClient).GetNum();
                adherent.adresse = ((Client)CompteClient).GetAdresse();
                adherent.code_ville = ((Client)CompteClient).GetCodeVille();
                adherent.tel = ((Client)CompteClient).GetTel();
                Users_Controller.GlobalVariables.UtilisateurConnecte = adherent;
             
                this.Close();
            }
            else if (CompteLocataire != null)
            {
                adherent.TypeCompte = "Locataire";
                adherent.numeroloc = ((Locataire_modele)CompteLocataire).GetNum();
                adherent.datenaiss = ((Locataire_modele)CompteLocataire).GetDteNaiss();
                adherent.R_I_B = ((Locataire_modele)CompteLocataire).GetRIB();
                adherent.banque = ((Locataire_modele)CompteLocataire).GetBanque();
                adherent.rue_banque = ((Locataire_modele)CompteLocataire).GetRue_Banque();
                adherent.codeville_banque = ((Locataire_modele)CompteLocataire).GetCodevilleBanque();
                adherent.tel_banque = ((Locataire_modele)CompteLocataire).GetTelBanque();
                
                Users_Controller.GlobalVariables.UtilisateurConnecte = adherent;
                MessageBox.Show($"Bonjour Mme/M {Users_Controller.GlobalVariables.UtilisateurConnecte.nom} dans mon application");
                this.Close();
            }
            else if (CompteProprietaire != null)
            {
                adherent.TypeCompte = "Proprietaire";
                adherent.numeroprop = ((Proprietaire_modele)CompteProprietaire).GetNum();
                adherent.adresse = ((Proprietaire_modele)CompteProprietaire).GetAdresse();
                adherent.code_ville = ((Proprietaire_modele)CompteProprietaire).GetCodeVille();
                adherent.tel = ((Proprietaire_modele)CompteProprietaire).GetTel();
                Users_Controller.GlobalVariables.UtilisateurConnecte = adherent;
                MessageBox.Show($"Bonjour Mme/M {Users_Controller.GlobalVariables.UtilisateurConnecte.nom} dans mon application");
             
                this.Close();
                
            }
            else
            {
                label1.Text = "Nom ou prénom est incorrecte";
            }


        }
    }
}