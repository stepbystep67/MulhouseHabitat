using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MulhouseHabitat.Models
{


    public class Logement
    {

        public List<Maison> Liste_maison { get; set; }

        public List<Appartement> Liste_appartement { get; set; }

        public int Id { get; set; }

        public int Pieces { get; set; }

        public string Surface { get; set; }

        public bool LibreOccupe { get; set; }

    }


}