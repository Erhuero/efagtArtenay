using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class ViewModele
    {
        public IEnumerable<Tickets> visualisationTickets { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<Barre> visualisationBarre { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<Cellule> visualisationCellule { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<Materiel> visualisationMateriel { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<NiveauUrgence> visualisationNiveauUrgence { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<Profil> visualisationProfil { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<Statut> visualisationStatut { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<TypeConnexion> visualisationTypeConnexion { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<TypeIP> visualisationTypeIP { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<TypeMateriel> visualisationTypeMateriel { get; set; }//recuperer les données sous forme d'une liste
        public IEnumerable<Utilisateur> visualisationUtilisateur { get; set; }//recuperer les données sous forme d'une liste
    }
}