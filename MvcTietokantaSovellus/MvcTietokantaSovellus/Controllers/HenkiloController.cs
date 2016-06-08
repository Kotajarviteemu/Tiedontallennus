using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTietokantaSovellus.Controllers
{
    public class HenkiloController : Controller
    {
        // GET: Henkilo
        public ActionResult Index()
        {
            return View();
        }
    }
}