using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Profil
    {
        [Key]
        [Display(Name = "Nom de la cellule du matériel")]
        public int idProfil { get; set; }

        [Display(Name = "Profil complet")]
        public int libelleProfil { get; set; }
    }
}