using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatientManagementApp.Data;
using PatientManagementApp.Models;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddDoctorPatient()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Doctor doc = new Doctor();
            doc.FirstName = "BIKASH";
            doc.LastName = "KHADKA";
            doc.Address = "DHN";
            doc.Specialist = "Orthopedic";
            doc.Qualification = "MBBS";
            Db.Doctors.Add(doc);
            Db.SaveChanges();
            //search doctor
            var doctor = (from temp in Db.Doctors where temp.FirstName == doc.FirstName select temp).ToList();
            PatientDetail pat = new PatientDetail();
            pat.FirstName = "Santosh";
            pat.LastName = "Shahi";
            pat.Country = "Nepal";
            pat.DOB = "1978";
            pat.DoctorFees = "500";
            pat.TypeOfPayment = "Cash";
            pat.DoctorToAttend = "Bhisma";
            pat.Discount = 100;
            pat.TotalBill = 400;
            pat.Doctor = doctor;
            Db.PatientDetails.Add(pat);
            Db.SaveChanges();
            }
    }
}
