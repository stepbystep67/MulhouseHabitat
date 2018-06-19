using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using MulhouseHabitat.Models;
using System.Web.Helpers;


namespace MulhouseHabitat.Controllers
{


    public class AppartementController : Controller
    {


        // GET: Appartement
        public ActionResult Index()
        {


            return View();
        }
    }
}