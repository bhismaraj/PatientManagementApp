using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PatientManagementApp.Data;
using PatientManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class PatientAPIController : ControllerBase
    {
        public ApplicationDbContext Db = null;
        public PatientAPIController(ApplicationDbContext _Db)
        {
            Db = _Db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            {
                var result = Db.PatientDetails.Include(c => c.PatientProblem).Include(a => a.Doctor).Where(b => b.IsActive == true).ToList();
                return Ok(result);
            }
        }

        // GET api/<PatientAPIController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = (from temp in Db.PatientDetails where temp.PatientId == id select temp).Include(a => a.Doctor)
                .Include(c => c.PatientProblem).FirstOrDefault();
                return Ok(result);
        }

        [HttpPost("{id}")]
        public IActionResult Post(int id, [FromBody] PatientDetail obj)
        {
            var doc = Db.Doctors.Where(a => a.Id == id).ToList();
            obj.Doctor = doc;
           /* var prob = Db.PatientProblems.Where(c => c.Id == id).ToList();
            obj.PatientProblems = prob;*/
            Db.Add(obj);
            Db.SaveChanges();
            return Ok("Patient added succesfully");
        }
    }
}
