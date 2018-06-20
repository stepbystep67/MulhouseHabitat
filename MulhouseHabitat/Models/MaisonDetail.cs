using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MulhouseHabitat.Models
{


    public class MaisonDetail
    {

        //un nombre de pièces et une surface habitable exprimée en Mètre carré. Il sera également nécessaire de précisier pour chaque logement s’il est actuellement loué ou non.

        public int Pieces { get; set; }

        public string Surface {get;set;}

        public bool LibreOccupe { get; set; }

    }


}
