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

       

        Dal dal;

        public LogementController()
        {

            dal = new Dal();

        }


        // GET: Logement
        public ActionResult Index()
        {


            return View(dal.GetLogement());
        }

        [HttpPost]
        public ActionResult Create(FormCollection formcollection)
        {

            try
            {

                Logement logement = new Logement();

                logement.LibreOccupe = bool.Parse(formcollection["LibreOccupe"]);

                logement.Pieces = int.Parse(formcollection["Pieces"]);

                logement.Surface = formcollection["Surface"];

                logement.Id = int.Parse(formcollection["Id"]);

                return View("Index"); 

            }
            catch
            {

                return View(dal.GetLogement());
            }



        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id)// reagi avec get mais pas post
        {

            Logement exist = dal.GetLogement().FirstOrDefault(x => x.Id == id);

          
          if (exist != default(Logement))
          {
                
                 // affiche le produit 
                 return View(exist);

          }
            
             // reaffiche la liste dorigine
             return RedirectToAction("index");
            
         }


        public ActionResult Details(Logement _logement)
        {

            Logement logement = dal.GetLogement().FirstOrDefault(x => (x.Id == _logement.Id));

            if(logement != default(Logement))
            {

                return View(dal.GetLogement(logement.Id));

            }

            return RedirectToAction("Index");

        }
     
        

    }


}
