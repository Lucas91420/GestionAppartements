using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondeappartement.Modèle
{
    class AdherentDAO
    {
        // Afficher les visiteurs/clients (Select * FROM Clients) 1 
        // Inserer une recherche d'appartement en fonction de differente de donnée pour les clients en recherche d'appartement donc des clients qui veulent devenir locataire 1
        // si client trouve une location, update de son statut (client->locataire)
        // Afficher les visiteurs avec leurs différences de statut (propriétaire, locataire, recherche de logement, un client qui devient un locataire) (Select) 1
        // Creation d'un nouveau locataire (Create)
        // Modifier appartement (Update)
        //Design d'une fonctionnalité où un visiteur peut visiter un appartement et devenir un locataire 
        //Insert d'une demande d'appart
        //Regarder ChatGpt
        //Refaire la bdd pour pouvoir, comprendre et traiter les visiteurs,clients,propriétaires et locataires 
        //Connexion tous les loc prop et cli peuvent se co
        // Suivre ton MCD
        // facultatif : ajouter supprimer modifier client prop loc 
        // regarder ancien projet pour voir la recherche et voirInfocli prop et loc
        // un adhérent peut voir ses propres informations et se déconnecter
        // reflechir si je devais faire un bail comme visiter cet apartement (ajouter un appart d'une list box à l'autre)
        public class Adherent
        {
            public string nom { get; set; }
            public string prenom { get; set; }
            public string TypeCompte { get; set; }
            public int num_cli { get; set; }
            public int numeroprop { get; set; }
            public string adresse { get; set; }
            public string code_ville { get; set; }
            public string tel { get; set; }
            public int numeroloc { get; set; }
            public DateTime datenaiss { get; set; }
            public int R_I_B { get; set; }
            public string banque { get; set; }
            public string rue_banque { get; set; }
            public string codeville_banque { get; set; }
            public string tel_banque { get; set; }

        }
    }
}
