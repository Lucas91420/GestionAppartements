using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    class Demande_modele
    {
        public int num_dem;
        public Client client;
        public string type_dem;
        public DateTime date_limite;
        public int nbjours;
        public DateTime datedebut;
        public DateTime datefin;
        public int arrondissement;
        public List<Demande_modele> LesDemandes;

        public Demande_modele(Client client, string type_dem, int num_dem, int arrondissement, DateTime date_limite,int nbjours, DateTime datedebut, DateTime datefin)
        {
            this.client = client;
            this.type_dem = type_dem;
            this.num_dem = num_dem;
            this.arrondissement = arrondissement;
            this.nbjours = nbjours;
            this.date_limite = date_limite;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.LesDemandes = new List<Demande_modele>();
        }

        public int GetNumDem()
        {
            return num_dem;
        }

        public Client GetClient()
        {
            return client;
        }

        public string GetTypeDem()
        {
            return type_dem;
        }

        public int GetArrondissement()
        {
            return arrondissement;
        }

        public DateTime GetDateLimite()
        {
            return date_limite;
        }
        public DateTime GetDateDebut()
        {
            return datedebut;
        }
        public DateTime GetDateFin()
        {
            return datefin;
        }
        public int GetNbJours()
        {
            return nbjours;
        }
        public void SetTypeDemande(string type_dem)
        {
            this.type_dem = type_dem;
        }
        public void SetArrondissement(int arrondissement)
        {
            this.arrondissement = arrondissement;
        }
        public void SetDateLimite(DateTime date_limite)
        {
            this.date_limite = date_limite;
        }

        public override string ToString()
        {
            return $"Numéro demande : {num_dem} | Type : {type_dem} | Date limite : {date_limite.ToString("dd/MM/yyyy")} | Nombre de jours : {nbjours} | Date de début : {datedebut} | Date de fin : {datefin} | Arrondissement : {arrondissement}";
        }

    }
}
