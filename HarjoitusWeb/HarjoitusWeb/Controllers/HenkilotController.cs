using HarjoitusWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarjoitusWeb.Controllers
{
    public class HenkilotController : Controller
    {
        // GET: Henkilot
        public ActionResult Index()
        {

            HarjoitusEntities entities = new HarjoitusEntities();
            List<Henkilot> model = entities.Henkilot.ToList();
            entities.Dispose();



            return View(model);
        }
    }
}