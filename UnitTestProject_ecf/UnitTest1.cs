using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MulhouseHabitat.Models;

namespace UnitTestProject_ecf
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            // creer une variable temporaire disponible que dans le using, methode dispose  
            using (Dal dal = new Dal())
            {

                // acces base de donnée + methode + instanciation d'un nouveau produit avec ses proprieté completées
                dal.AddLogement(new Logement { LibreOccupe = true, Pieces = 10, Surface = "1445m2" });

                // instanciation d'une liste de produit ou l'on y mets le resultat de la méthode qui retourne une liste
                List<Logement> logement = dal.GetLogements();

                Assert.AreEqual("", logement[0].Id);


                Assert.AreEqual("", logement[0].LibreOccupe);

            }

        }
    }
}
