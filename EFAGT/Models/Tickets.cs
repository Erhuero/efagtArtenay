using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Tickets
    {
        [Key]
        [Display(Name = "Numéro du ticket")]
        public int idTicket { get; set; }

        [Display(Name = "Cellule")]
        public string emplacementMaterielTicket{ get; set; }

        [Display(Name = "Type de matériel")]
        public string typeMaterielTicket { get; set; }

        [Display(Name = "Description de l'incident")]
        public string descriptionIncident { get; set; }

        [Display(Name = "Date de creation d'incident")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime dateCreationIncident { get; set; }

        [Display(Name = "Date de cloture")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]              
        public DateTime dateClotureIncident { get; set; }

        [Display(Name = "Nom de la cellule")]
        public string nomCellule { get; set; }

        [Display(Name = "Numéro de série")]
        public string numeroSerieMAteriel { get; set; }

        [Display(Name = "Statut")]
        public string etatStatut { get; set; }
    }
}