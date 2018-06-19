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


    public class LogementController : Controller
    {

        public LogementController logement = new LogementController();

        Dal dal;

        public LogementController()
        {

            dal = new Dal();

        }


        // GET: Logement
        public ActionResult Index()
        {


            return View("Index");
        }


    }


}