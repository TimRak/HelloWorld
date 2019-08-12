using HelloWorld.Models;
using HelloWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {

            ViewModels.AccueilViewModel vm = new AccueilViewModel
            {
                Message = "Bonjour depuis le contrôleur",
                Date = DateTime.Now,
                Resto = new Resto { Nom = "La bonne fourchette", Telephone = "1234" }
            };
            return View(vm);


            if (string.IsNullOrWhiteSpace(id))
            {
                return View("Error");
            }
            else
            {
                ViewBag.Nom = id;
                return View();
            }
        }


        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewData["Clients"] = clients.ObtenirListeClients();
            return View();
        }

        public ActionResult ChercheClient(string id)
        {
            ViewData["Nom"] = id;
            Clients clients = new Clients();
            Client client = clients.ObtenirListeClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["Age"] = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
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