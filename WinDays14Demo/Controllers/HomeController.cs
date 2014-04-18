using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WinDays14Demo.Models;

namespace WinDays14Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            SpeakersRepository repository = new SpeakersRepository();
            var speakers = repository.GetAllSpeakers();

            ViewBag.Speakers = speakers;

            return View();
        }
    }
}