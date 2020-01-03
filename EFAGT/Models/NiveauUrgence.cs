using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class NiveauUrgence
    {
        [Key]
        [Display(Name = "Ientification de l'urgence")]
        private string idNiveauUrgence { get; set; }

        [Display(Name = "Niveau d'urgence")]
        private string libelleUrgence { get; set; }
    }
}