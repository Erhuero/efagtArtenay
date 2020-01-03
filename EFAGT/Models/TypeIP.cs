using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class TypeIP
    {
        [Key]
        [Display(Name = "Identification de l'adresse IP")]
        public string typeIP { get; set; }

        [Display(Name = "Adresse IP fixe ou mobile")]
        public string libelleIP { get; set; }
    }
}