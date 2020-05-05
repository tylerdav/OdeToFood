using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, name = "Scott's Pizza", Location= "Maryland", CuisineType=CuisineType.Italian },
                new Restaurant {Id = 1, name = "Cinnamon Club", Location= "Tennessee", CuisineType=CuisineType.Italian },
                new Restaurant {Id = 1, name = "La Costa", Location= "Florida", CuisineType=CuisineType.Italian },
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
