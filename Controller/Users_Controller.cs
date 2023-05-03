using System;
using System.Collections.Generic;
using System.Text;
using gestiondeappartement.Modèle;

namespace gestiondeappartement.Controller
{
    class Users_Controller
    {
        public static class GlobalVariables
        {
            public static AdherentDAO.Adherent UtilisateurConnecte { get; set; }
        }
    }
}
