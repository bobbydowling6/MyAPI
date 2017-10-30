using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace MyAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<Models.Car> cars = new List<Models.Car>();

        public IEnumerable<Models.Car> Get()
        {
            return cars.ToArray();
        }

        public Models.Car Get(int id)
        {
            return cars.ElementAt(id);
        }

        public void Post(Models.Car value)
        {
            cars.Add(value);
        }

        public void Put(int id, Models.Car value)
        {
            cars[id] = value;
        }

        public void Delete(int id)
        {
            cars.RemoveAt(id);
        }
    }
}