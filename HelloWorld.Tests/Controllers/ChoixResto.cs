using System;
using System.Collections.Generic;
using HelloWorld.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static HelloWorld.Models.Dal;

namespace HelloWorld.Tests.Controllers
{
   [TestClass]
public class DalTests
{
    [TestMethod]
    public void CreerRestaurant_AvecUnNouveauRestaurant_ObtientTousLesRestaurantsRenvoitBienLeRestaurant()
    {
        using (Models.IDal dal = new Dal())
        {
            dal.CreerRestaurant("La bonne fourchette", "01 02 03 04 05");
            List<Resto> restos = dal.ObtientTousLesRestaurants();
                
            Assert.IsNotNull(restos);
            Assert.AreEqual(1, restos.Count);
            Assert.AreEqual("La bonne fourchette", restos[0].Nom);
            Assert.AreEqual("01 02 03 04 05", restos[0].Telephone);
        }
    }
}
}
