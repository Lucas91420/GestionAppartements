using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    class Client
    {
        private int num_cli;
        private string nom;
        private string prenom;
        private string adresse;
        private string codeville;
        private string tel;
        private List<Client> LesClients;
        public string TypeCompte { get; set; }

        public Client(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public Client(int num_cli, string nom, string prenom)
        {
            this.num_cli = num_cli;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Client(int num_cli, string nom, string prenom, string adresse, string codeville,string tel)
        {
            this.num_cli = num_cli;
            this.nom = nom;
            this.prenom = prenom;   
            this.adresse = adresse;
            this.codeville = codeville;
            this.tel = tel;
            this.LesClients = new List<Client>();
        }
        public int GetNum()
        {
            return num_cli;
        }
        public string GetNom()
        {
            return nom;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public string GetAdresse()
        {
            return adresse;
        }
        public string GetCodeVille()
        {
            return codeville;
        }
        public string GetTel()
        {
            return tel;
        }
        public override string ToString()
        {
            return $"NumeroCli: {num_cli} | Nom: {nom} | Prenom: {prenom} | Adresse: {adresse} | CodeVille: {codeville} | Tel: {tel}";
        }

        //public override bool Equals(object obj)
        //{
        //    Compte s;
        //    if (obj is Compte)
        //    {
        //        s = (Compte)obj;
        //        if (this.nom == s.nom )
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
