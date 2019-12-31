using EFAGT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using EFAGT.Models;
namespace EFAGT.Controllers
{
    public class HomeController : Controller
    {
        DAL dataLayer = new DAL();

        public ActionResult Index()
        {
            ViewModele modele = new ViewModele();

            modele.visualisationTickets = dataLayer.requeteAffiche();

            return View(modele);
        }

        public ActionResult insertionTickets()
        {
            return PartialView();
        }













        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}