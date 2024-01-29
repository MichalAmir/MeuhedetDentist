using MeuhedetDentist.Entities;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeuhedetDentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class doctorsController : ControllerBase
    {
        private readonly DataContext _contextC;
        public doctorsController(DataContext context)
        {
            _contextC = context;
        }
    
        // GET: api/<doctorsController>
        [HttpGet]
        public IEnumerable<doctors> Get()
        {
            return _contextC.doctors;
        }

        // GET api/<doctorsController>/5
        [HttpGet("{id}")]
        public doctors Get(int IdDoctors)
        {
            foreach (var doctor in _contextC.doctors)
            {
                if(IdDoctors == doctor.Id)
                    return doctor;
            }
            return null;
        }

        // POST api/<doctorsController>
        [HttpPost]
        public void Post([FromBody] doctors value)
        {
            _contextC.doctors.Add(new doctors { IdDoctors=value.IdDoctors,NameDoctors=value.NameDoctors,SalaryDoctors=value.SalaryDoctors,HoursDoctors=value.HoursDoctors});
        }

        // PUT api/<doctorsController>/5
        [HttpPut("{id}")]
        public void Put(int IdDoctors, [FromBody] doctors value)
        {
            foreach(var doctor in _contextC.doctors)
            {
                if (doctor.IdDoctor == IdDoctors)
                {
                    doctor.IdDoctor=value.IdDoctors;
                    doctor.NameDoctors = value.NameDoctors;
                    doctor.SalaryDoctors = value.SalaryDoctors;
                    doctor.HoursDoctors = value.HoursDoctors;            
                }
            }
        }
    }
}