using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class Utilisateur
    {

        [Key]
        [Display(Name = "Identifiant de l'utilisateur")]
        public int idUtilisateur { get; set; }

        [Display(Name = "Nom de l'utilisateur")]
        public int nomUtilisateur { get; set; }

        [Display(Name = "Prénom de l'utilisateur")]
        public int prenomUtilisateur { get; set; }

        [Display(Name = "Téléphone de l'utilisateur")]
        public int telephoneUtilisateur { get; set; }

        [Display(Name = "Mail de l'utilisateur")]
        public int mailUtilisateur { get; set; }

        [Display(Name = "Grade de l'utilisateur")]
        public int gradeUtilisateur { get; set; }

        [Display(Name = "Id profil")]
        public int idProfil { get; set; }



    }
}