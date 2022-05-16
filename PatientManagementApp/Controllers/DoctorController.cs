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
    public class DoctorController : ControllerBase
    {
        public ApplicationDbContext Db = null;
        public DoctorController(ApplicationDbContext _Db)
        {
            Db = _Db;
        }
        // GET: api/<Doctor>
        [HttpGet]
        public IActionResult Get()
        {
            var result = Db.Doctors.ToList();
            return Ok(result);
        }

        // GET api/<Doctor>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = Db.Doctors.Where(c => c.Id == id).FirstOrDefault();
            return Ok(result);
        }

        // POST api/<Doctor>
        [HttpPost]
        public IActionResult Post([FromBody] Doctor doc)
        {
            Db.Add(doc);
            Db.SaveChanges();
            return Ok("Added Successfully");
        }

        // PUT api/<Doctor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
