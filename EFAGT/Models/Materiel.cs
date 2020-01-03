using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Materiel
    {
        [Key]
        [Display(Name = "Numero de série")]
        private int numeroSerieMateriel { get; set; }

        [Display(Name = "Emplacement de l'appareil")]
        private string emplacementMateriel { get; set; }

        [Display(Name = "Le modèle de l'appareil")]
        private string modeleMateriel { get; set; }

        [Display(Name = "Adrese IP de l'appareil")]
        private string ipMateriel { get; set; }

        [Display(Name = "IP fixe ou mobile")]
        private string typeIPMateriel { get; set; }

        [Display(Name = "Identifiant INFOLOG de l'appareil")]
        private string numInfologMateriel { get; set; }

        [Display(Name = "Nom de la cellule du matériel")]
        private string celluleMateriel { get; set; }

        [Display(Name = "Appareil nouveau ou usagé")]
        private string etatMateriel { get; set; }

        [Display(Name = "Numéro du chariot affecté à l'appareil")]
        private string numeroChariot { get; set; }

        [Display(Name = "Identifiant de l'utilisateur")]
        private string idUtilisateur { get; set; }

        [Display(Name = "Connexion filaire ou Wi-Fi")]
        private string typeConnexion { get; set; }

        [Display(Name = "Identifiant de la cellule")]
        private string idCellule { get; set; }

        [Display(Name = "Identifiant de la barre")]
        private string idBarre { get; set; }

        [Display(Name = "Type adresse IP")]
        private string typeIP { get; set; }
        
    }
}