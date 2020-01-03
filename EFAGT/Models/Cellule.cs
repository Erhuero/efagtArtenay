using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Cellule
    {
        [Key]
        [Display(Name = "Identification de la cellule")]
        private int idCellule { get; set; }

        [Display(Name = "Numero de cellule")]
        private string libelleCellule { get; set; }
    }
}