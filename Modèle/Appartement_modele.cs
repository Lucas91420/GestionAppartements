using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    public class Appartements
    {
        private int numappart;
        public string typappart;
        public decimal prix_loc;
        private decimal prix_charg;
        private string rue;
        public int arrondissement;
        private int etage;
        private int ascenseur;
        private int preavis;
        private DateTime date_libre;
        private int courtduree;
        private int numeroprop;
        private int numeroloc;
        private List<Appartements> LesAppartements;

        public Appartements(int numappart, string typappart, decimal prix_loc, decimal prix_charg, string rue, int arrondissement, int etage, int ascenseur, int preavis, DateTime date_libre, int courtduree, int numeroprop, int numeroloc)
        {
            this.numappart = numappart;
            this.typappart = typappart;
            this.prix_loc = prix_loc;
            this.prix_charg = prix_charg;
            this.rue = rue;
            this.arrondissement = arrondissement;
            this.etage = etage;
            this.ascenseur = ascenseur;
            this.preavis = preavis;
            this.date_libre = date_libre;
            this.courtduree = courtduree;
            this.numeroprop = numeroprop;
            this.numeroloc = numeroloc;
            this.LesAppartements = new List<Appartements>();
        }
        public int GetNumAppart()
        {
            return numappart;
        }
        public int GetEtage()
        {
            return etage;
        }
        public string GetTypappart()
        {
            return typappart;
        }
        public decimal GetPrixLoc()
        {
            return prix_loc;
        }
        public decimal GetPrixCharg()
        {
            return prix_charg;
        }
        public string GetRue()
        {
            return rue;
        }
        public int GetArrondissement()
        {
            return arrondissement;
        }
        public int GetAscenceur()
        {
            return ascenseur;
        }
        public int GetPreavis()
        {
            return preavis;
        }
        public DateTime GetDateLibre()
        {
            return date_libre;
        }
        public int GetCourtDuree()
        {
            return courtduree;
        }

        public int GetNumprop()
        {
            return numeroprop;
        }
        public int GetNumloc()
        {
            return numeroloc;
        }
        public override string ToString()
        {
            return $"NumeoAppart: {numappart} | Type: {typappart} | Prix Location: {prix_loc} | Prix Charge: {prix_charg} | Rue: {rue} | Arrondissement: {arrondissement}  | Etage: {etage} | Ascenseur: {ascenseur}  | Preavis: {preavis}  | Date: {date_libre}  | Courtduree : {courtduree} | NumeroProp: {numeroprop}  | NumeroLoc: {numeroloc}   ";
        }
    }
}
