using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Statut
    {
        [Key]
        [Display(Name = "Nom de la cellule du matériel")]
        public int etatStatut { get; set; }

        [Display(Name = "Nom de la cellule du matériel")]
        public string libelleStatut { get; set; }
    }
}