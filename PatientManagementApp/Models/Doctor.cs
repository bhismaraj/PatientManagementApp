using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PatientManagementApp.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Specialist { get; set; }
        public string Qualification { get; set; }
        [JsonIgnore]
        public List<PatientDetail> PatientDetails { get; set; }
    }
}
