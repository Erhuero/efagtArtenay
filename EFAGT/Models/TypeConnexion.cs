using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class TypeConnexion
    {
        [Key]
        [Display(Name = "Identification de la connexion")]
        public string typeConnexion { get; set; }

        [Display(Name = "Filaire ou Wi-Fi")]
        public string descriptionConnexion { get; set; }
    }
}