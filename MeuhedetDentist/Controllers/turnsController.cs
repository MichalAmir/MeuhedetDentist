using MeuhedetDentist.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeuhedetDentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class turnsController : ControllerBase
    {

        private readonly DataContext _contextT;
        public turnsController(DataContext context)
        {
            _contextC = context;
        }

        // GET: api/<turnsController>
        [HttpGet]
        public IEnumerable<turns> Get()
        {
            return _contextT.turns;
        }

        // GET api/<turnsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            foreach(var turns in _contextT.turns)
            {
                if(turns.NumTurn.Equals(id))
                    return Ok(turns);
            }
            return NotFound();
        }

        // POST api/<turnsController>
        [HttpPost]
        public void Post([FromBody] turns value)
        {
            _contextT.turns.Add(new turns { NumTurn=value.NumTurn, DateTimeTurn=value.DateTimeTurn, IsAvailableTurn=value.IsAvailableTurn, NumRoom=value.NumRoom});
        }

        // PUT api/<turnsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] turns value)
        {
            foreach(var turns in _contextT.turns)
            {
                if (turns.NumTurn.Equals(id))
                {
                    turns.NumTurn = value.NumTurn;
                    turns.DateTimeTurn = value.DateTimeTurn;
                    turns.IsAvailableTurn = value.IsAvailableTurn;
                    turns.NumRoom = value.NumRoom;
                    return Ok();    
                }
            }
            return NotFound();
        }

        // DELETE api/<turnsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach(var turns in _contextT.turns)
            {
                if (turns.NumTurn.Equals(id))
                {
                    _contextT.turns.Remove(turns);
                    return Ok();
                }
            }
            return NotFound();
        }
    }
}
