using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PatientManagementApp.Data;
using PatientManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class PatientProblemController : ControllerBase
    {
        public ApplicationDbContext Db = null;
        public PatientProblemController(ApplicationDbContext _Db)
        {
            Db = _Db;
        }
        // GET: api/<PatientProblemController>
        [HttpGet]
        public IActionResult Get()
        {

            var result = Db.PatientProblem.ToList();
            return Ok(result);
        }

        // GET api/<PatientProblemController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var result = Db.PatientProblem.Where(d => d.Id == id).FirstOrDefault();
            return Ok(result);
        }


        // POST api/<PatientProblemController>
        [HttpPost("{id}")]
        public IActionResult Post(int id, [FromBody] PatientProblems prob)
        {
            var pat = Db.PatientDetails.Where(a => a.PatientId == id).FirstOrDefault();
            prob.PatientDetailId = pat;
            Db.Add(prob);
            Db.SaveChanges();
            return Ok("Added Successfully");
        }

        // PUT api/<PatientProblemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientProblemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
