using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Tickets
    {
        [Display(Name = "Numéro du ticket")]
        public int idTicket { get; set; }
        public string emplacementMaterielTicket{ get; set; }
        public string typeMaterielTicket { get; set; }
        public string descriptionIncident { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime dateCreationIncident { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime dateClotureIncident { get; set; }

        public string nomCellule { get; set; }
        public string numeroSerieMAteriel { get; set; }
        public string etatStatut { get; set; }
    }
}