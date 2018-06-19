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

        public List<Logement> GetLogements()
        {

            return db.Logements.ToList();

        }


}


}