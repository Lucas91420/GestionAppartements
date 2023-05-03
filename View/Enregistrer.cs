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
    public partial class EnregistrerFRM : Form
    {
        public EnregistrerFRM()
        {
            InitializeComponent();
        }

        private void btnEnregistrerFormulaire_Click(object sender, EventArgs e)
        {
                int numappart;
                decimal prixLoc;
                decimal prixCharg;
                int arrondissement;
                int etage;
                int ascenseur;
                int preavis;
                int courtduree;
                int numprop;
                int numloc; 

                bool ConvertNumAppart = int.TryParse(txtNumAppart.Text, out numappart);
                bool ConvertPrixLoc = decimal.TryParse(txtPrixLoc.Text, out prixLoc);
                bool ConvertPrixCharg = decimal.TryParse(txtPrixCharge.Text, out prixCharg);
                bool ConvertArrondissement = int.TryParse(txtArrondissement.Text, out arrondissement);
                bool ConvertEtage = int.TryParse(txtEtage.Text, out etage);
                bool ConvertAscenseur = int.TryParse(txtAscenseur.Text, out ascenseur);
                bool ConvertPreavis = int.TryParse(txtPreavis.Text, out preavis);
                bool ConvertCourtduree = int.TryParse(txtCourtduree.Text, out courtduree);
                bool ConvertNumprop = int.TryParse(txtNumProp.Text, out numprop);
                bool ConvertNumloc = int.TryParse(txtNumLoc.Text, out numloc);

                if (ConvertPrixLoc && ConvertPrixCharg && ConvertArrondissement && ConvertEtage && ConvertAscenseur && ConvertPreavis && ConvertNumprop && ConvertNumloc && ConvertNumAppart)
                {
                    string typappart = comboBoxType.SelectedItem.ToString();
                    string rue = txtRue.Text;
                    DateTime datelibre = DTPDATE.Value;

                    // Vérifier si le numéro d'appartement est déjà présent dans la base de données
                    if (AppartementDAO.VerifierNumeroAppartement(numappart))
                    {
                        MessageBox.Show("Le numéro d'appartement est déjà utilisé.");
                        return;
                    }

                    // Vérifier si le numéro de propriétaire est déjà présent dans la base de données
                    if (ProprietaireDAO.VerifierNumeroProprietaire(numprop))
                    {
                        MessageBox.Show("Le numéro de propriétaire est déjà utilisé.");
                        return;
                    }

                    // Vérifier si le numéro de locataire est déjà présent dans la base de données
                    if (LocataireDAO.VerifierNumeroLocataire(numloc))
                    {
                        MessageBox.Show("Le numéro de locataire est déjà utilisé.");
                        return;
                    }

                    Appartements a = new Appartements(numappart, typappart, prixLoc, prixCharg, rue, arrondissement, etage, ascenseur, preavis, datelibre,courtduree, numprop, numloc);
                    bool result = AppartementDAO.AjouterAppartement(a);

                    if (result)
                    {
                        MessageBox.Show("L'appartement a été ajouté avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout de l'appartement.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs avec des valeurs valides !");
                }
        }

        private void comboBoxType_DropDown(object sender, EventArgs e)
        {
            /*comboBoxType.Items.Clear();
            List<string> LesTypes = AppartementDAO.GetToutesLesTypes();
            foreach (string element in LesTypes)
            {
                comboBoxType.Items.Add(element);
            }
            */
            comboBoxType.Items.AddRange(new object[] { "Studio", "F1", "F2", "F3", "F4", "F5" });

        }
        private void ListTypeAppartemment(object sender, EventArgs e)
        {
            // Créer une liste contenant les types d'appartements
            List<string> typesAppartement = new List<string>();
            typesAppartement.Add("Studio");
            typesAppartement.Add("F1");
            typesAppartement.Add("F2");
            typesAppartement.Add("F3");
            typesAppartement.Add("F4");
            typesAppartement.Add("F5");

            // Assigner la liste au ComboBox
            comboBoxType.DataSource = typesAppartement;
        }
        private void btnEffacerArticle_Click(object sender, EventArgs e)
        {
            comboBoxType.SelectedItem = "";
            txtNom.Text = "";
            txtPrixLoc.Text = "";
            txtRue.Text = "";
            txtPrixCharge.Text = "";
            txtRue.Text = "";
            txtArrondissement.Text = "";
            txtEtage.Text = "";
            txtAscenseur.Text = "";
            txtPreavis.Text = "";
            txtNumProp.Text = "";
            txtNumLoc.Text = "";
            txtNumAppart.Text = "";


        }

        private void btnQuitterEnregistrerArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnregistrerFRM_Load(object sender, EventArgs e)
        {

        }
    }
    
}
