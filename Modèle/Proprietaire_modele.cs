using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    class Proprietaire_modele
    {
        private int numeroprop;
        private string nom;
        private string prenom;
        private string adresse;
        private string code_ville;
        private string tel;
        private List<Proprietaire_modele> LesProprietaires;
        public string TypeCompte { get; set; }

        public Proprietaire_modele(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public Proprietaire_modele(int numeroprop, string nom, string prenom)
        {
            this.numeroprop = numeroprop;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Proprietaire_modele(int numeroprop, string nom, string prenom, string adresse, string code_ville, string tel)
        {
            this.numeroprop = numeroprop;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.code_ville = code_ville;
            this.tel = tel;
            this.LesProprietaires = new List<Proprietaire_modele>();
        }

        public int GetNum()
        {
            return numeroprop;
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
            return code_ville;
        }
        public string GetTel()
        {
            return tel;
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
        public override string ToString()
        {
            return $"NumeroProp: {numeroprop} | Nom: {nom} | Prenom: {prenom} | Adresse: {adresse} | CodeVille: {code_ville} | Tel: {tel}";
        }

    }
}

