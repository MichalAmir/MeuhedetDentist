using MeuhedetDentist.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeuhedetDentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class clientsController : ControllerBase
    {
        
        private readonly DataContext _contextC;
        public clientsController(DataContext context)
        {
            _contextC = context;
        }

        //GET: api/<clientsController>
        [HttpGet]
        public List<clients> Get()
        {
            return _contextC.clients;
        }

        // GET api/<clientsController>/5
        [HttpGet("{id}")]
        public clients Get(int id)
        {
            foreach (clients client in _contextC.clients)
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
            clients new_client = new clients { IdClient = value.IdClient, NameClient = value.NameClient, AgeClient = value.AgeClient, AdressClient = value.AdressClient };
            _contextC.clients.Add(new_client);
        }

        // PUT api/<clientsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] clients value)
        {
            clients update_client = new clients { IdClient = value.IdClient, NameClient = value.NameClient, AgeClient = value.AgeClient, AdressClient = value.AdressClient };
            foreach (clients client in _contextC.clients)
            {
                if (client.IdClient == id)
                {
                    client.IdClient = update_client.IdClient;
                    client.NameClient = update_client.NameClient;
                    client.AgeClient = update_client.AgeClient;
                    client.AdressClient = update_client.AdressClient;
                }
            }

        }
    }
     
}

