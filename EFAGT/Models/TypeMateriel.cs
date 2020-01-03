using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class TypeMateriel
    {
        [Key]
        [Display(Name = "Identification materiel")]
        public int typeMateriel { get; set; }

        [Display(Name = "Description du matériel")]
        public string libelleMateriel { get; set; }
    }
}