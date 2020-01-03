using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFAGT.Models
{
    public class ViewModele
    {
        public IEnumerable<Tickets> visualisationTickets { get; set; }//recuperer les données sous forme d'une liste
    }
}