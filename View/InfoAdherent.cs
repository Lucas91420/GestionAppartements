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

namespace gestiondeappartement
{
    public partial class InfoAdherent : Form
    {
        public InfoAdherent()
        {
            InitializeComponent();
        }

        private void Paiement_Load(object sender, EventArgs e)
        {

        }

        private void btnVoir_Click(object sender, EventArgs e)
        {

            AdherentDAO.Adherent adherent = Users_Controller.GlobalVariables.UtilisateurConnecte;
            if (adherent != null)
            {
            
                if (adherent.TypeCompte == "Client")
                {
                    Client client = ClientDAO.GetLesClients().FirstOrDefault(c => c.GetNum() == adherent.num_cli);
                    if (client != null)
                    {
                        lblNum.Text = client.GetNum().ToString();
                        lblNom.Text = client.GetNom();
                        lblPrenom.Text = client.GetPrenom();
                        lblAdresse.Text = client.GetAdresse();
                        lblCodeVille.Text = client.GetCodeVille();
                        lblTel.Text = client.GetTel();
                    }
                }
                else if (adherent.TypeCompte == "Proprietaire")
                {
                    Proprietaire_modele proprietaire = ProprietaireDAO.GetLesProprietaires().FirstOrDefault(p => p.GetNum() == adherent.numeroprop);
                    if (proprietaire != null)
                    {
                        lblNom.Text = proprietaire.GetNom();
                        lblPrenom.Text = proprietaire.GetPrenom();
                        lblAdresse.Text = proprietaire.GetAdresse();
                        lblCodeVille.Text = proprietaire.GetCodeVille();
                        lblTel.Text = proprietaire.GetTel();
                    }
                }
                else if (adherent.TypeCompte == "Locataire")
                {
                    Locataire_modele locataire = LocataireDAO.GetLesLocataires().FirstOrDefault(l => l.GetNum() == adherent.numeroloc);
                    if (locataire != null)
                    {
                        lblNom.Text = locataire.GetNom();
                        lblPrenom.Text = locataire.GetPrenom();
                        lblDteNaiss.Text = locataire.GetDteNaiss().ToString("dd/MM/yyyy");
                        lblTel.Text = locataire.GetTel();
                        lblRIB.Text = locataire.GetRIB().ToString();
                        lblBanque.Text = locataire.GetBanque();
                        lblRueBanque.Text = locataire.GetRue_Banque();
                        lblCodeVilleBanque.Text = locataire.GetCodevilleBanque();
                        lblTelBanque.Text = locataire.GetTelBanque();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
