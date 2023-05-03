using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    class Locataire_modele
    {
        private int numeroloc;
        private string nom;
        private string prenom;
        private DateTime datenaiss;
        private string tel;
        private int R_I_B;
        private string banque;
        private string rue_banque;
        private string codeville_banque;
        private string tel_banque;
        private List<Locataire_modele> LesLocataires;
        public string TypeCompte { get; set; }

        public Locataire_modele(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public Locataire_modele(int numeroloc, string nom, string prenom)
        {
            this.numeroloc = numeroloc;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Locataire_modele(int numeroloc, string nom, string prenom, DateTime datenaiss, string tel, int R_I_B, string banque, string rue_banque, string codeville_banque, string tel_banque)
        {
            this.numeroloc = numeroloc;
            this.nom = nom;
            this.prenom = prenom;
            this.datenaiss = datenaiss;
            this.tel = tel;
            this.R_I_B = R_I_B;
            this.banque = banque;
            this.rue_banque = rue_banque;
            this.codeville_banque = codeville_banque;
            this.tel_banque = tel_banque;
            this.LesLocataires = new List<Locataire_modele>();
        }
        public int GetNum()
        {
            return numeroloc;
        }
        public string GetNom()
        {
            return nom;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public DateTime GetDteNaiss()
        {
            return datenaiss;
        }
        public string GetTel()
        {
            return tel;
        }
        public int GetRIB()
        {
            return R_I_B;
        }
        public string GetBanque()
        {
            return banque;
        }
        public string GetRue_Banque()
        {
            return rue_banque;
        }
        public string GetCodevilleBanque()
        {
            return codeville_banque;
        }
        public string GetTelBanque()
        {
            return tel_banque;
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
            return $"NumeroLoc: {numeroloc} | Nom: {nom} | Prenom: {prenom} | DteNaissance: {datenaiss} | Telephone: {tel} | RIB: {R_I_B} | Banque: {banque} | Rue banque: {rue_banque} | CodeVille banque: {codeville_banque} | Telephone banque: {tel_banque}";
        }

    }
}
