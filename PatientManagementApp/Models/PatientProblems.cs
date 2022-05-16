using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagementApp.Models
{
    public class PatientProblems
    {
        public int Id { get; set; }
        public string ProblemType { get; set; }
        public string Description { get; set; }
        public int PatientId { get; set; }
        public PatientDetail PatientDetailId { get; set; }
        public List<PatientMedications> PatientMedications { get; set; }
        public Boolean IsActive { get; set; }
      
    }
}
