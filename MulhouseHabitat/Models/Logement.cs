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

        public int Id { get; set; }

        public int Pieces { get; set; }

        public string Surface { get; set; }

        public bool LibreOccupe { get; set; }

    }


}