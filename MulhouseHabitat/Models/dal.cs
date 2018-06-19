using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


// data access layer
// aussi appeler dao = data acces object
// fais le lien entre le model c# et celui asp.net
namespace MulhouseHabitat.Models
{


    public class Dal : IDisposable
    {


        private BddContext db;


        // constructeur par defaut
        public Dal()
        {

            db = new BddContext();

        }


       public void Dispose()
       {

            db.Dispose();
            
       }

        public List<Logement> GetLogement()
        {

            return db.Logements.ToList();

        }

        // ajout d'un logement
        public void AddLogement(Logement logement)
        {

            db.Logements.Add(logement);
            db.SaveChanges();

        }


        public Logement GetLogement(int _id)
        {

            // retourne le produit correspondant 
            return db.Logements.FirstOrDefault(x => (x.Id == _id));
        }

        // obtient la liste 
        public List<Logement> GetLogements(Predicate<Logement> predicate)
        {

            List<Logement> result = new List<Logement>();

            foreach(Logement l in db.Logements)
            {

                if(predicate(l))
                {

                    result.Add(l);

                }

            }

            return result;
        }
      
       
    }


}