using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public interface IDal : IDisposable
    {
        void CreerRestaurant(string nom, string telephone);
        void ModifierRestaurant(int id, string nom, string telephone);
        List<Resto> ObtientTousLesRestaurants();
    }
}