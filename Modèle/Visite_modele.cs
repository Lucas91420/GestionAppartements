using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    public class Visite_modele
    {
        public int num_cli { get; set; }
        public int NumAppart { get; set; }
        public DateTime? DateVisite { get; set; }
        public List<Visite_modele> LesVisites;

        public Visite_modele(int numCli, int numAppart, DateTime? dateVisite)
        {
            num_cli = num_cli;
            NumAppart = numAppart;
            DateVisite = dateVisite;
            this.LesVisites = new List<Visite_modele>();
        }

        public override string ToString()
        {
            return $"Numéro client : {num_cli}, Numéro appartement : {NumAppart}, Date visite : {DateVisite?.ToString() ?? "Non planifiée"}";
        }

    }
}
