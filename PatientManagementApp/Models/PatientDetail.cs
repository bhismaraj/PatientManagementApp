using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagementApp.Models
{
    [JsonObject(IsReference = false)]
    public class PatientDetail
    {
        [Key]
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Country   { get; set; }
        public string DOB { get; set; }
        public string DoctorFees { get; set; }
        public string TypeOfPayment { get; set; }
        public string DoctorToAttend { get; set; }
        public int Discount { get; set; }
        public int TotalBill { get; set; }
        public List<PatientProblems> PatientProblem { get; set; }
        public int DoctorId { get; set; }
        public List<Doctor> Doctor { get; set; }
        public Boolean IsActive { get; set; }
        public PatientDetail()
        {
            this.IsActive = true;
        }

    }
}
