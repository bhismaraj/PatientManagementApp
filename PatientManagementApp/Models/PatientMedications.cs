using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagementApp.Models
{
    public class PatientMedications
    {
        public int Id { get; set; }
        public string TimesPerDay { get; set; }
        public string Description { get; set; }
        public int PatientProblemsId { get; set; }
        public PatientProblems PatientProblems { get; set; }

    }
}
