using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Barre
    {
        [Key]
        [Display(Name = "Identifiant de la barre")]
        public int idBarre { get; set; }
        
        [Display(Name = "Barre A ou B")]
        public string libelleBarre { get; set; }
    }
}