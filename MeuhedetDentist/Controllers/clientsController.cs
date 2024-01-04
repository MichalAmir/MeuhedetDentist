using MeuhedetDentist.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeuhedetDentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clientsController : ControllerBase
    {
        private static List<clients> clients = new List<clients> {
            new clients { IdClient = "123", NameClient = "Hadas", AgeClient = 20 ,AdressClient="Bnei Brak Makover 15"},
            new clients { IdClient = "121", NameClient = "Avishag", AgeClient = 18,AdressClient="Bnei Brak Pinkas 8" },
            new clients { IdClient = "323", NameClient = "Ruthi", AgeClient = 5,AdressClient="Beit Shemesh Beri 10" }
        };
        private static int countId = 4;
        // GET: api/<clientsController>
        [HttpGet]
        public IEnumerable<clients> Get()
        {
            return clients;
        }

        // GET api/<clientsController>/5
        [HttpGet("{id}")]
        public clients Get(string id)
        {
            foreach (clients client in clients)
            {
                if (client.IdClient == id)
                    return client;
            }
            return null;
        }

        // POST api/<clientsController>
        [HttpPost]
        public void Post([FromBody] clients value)
        {
            clients.Add(new clients { IdClient = value.IdClient, NameClient = value.NameClient, AgeClient = value.AgeClient, AdressClient.value = AdressClient });
            countId++;
            return clients[clients.Count - 1];
        }

        // PUT api/<clientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<clientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

