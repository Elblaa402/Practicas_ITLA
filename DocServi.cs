using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.model;
using Hospital.dbcontext;

namespace hospital.services
{
    internal class DocServices
    {
        public static void AddDoctor(string name, string lastname, string cellphone, string especialidad = "general")
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            var doctor = new model.Doctor
            {
                Name = name,
                Lastname = lastname,
                Cellphone = cellphone,
                Especialidad = especialidad 

            };
            db.Doctores.Add(doctor);
            db.SaveChanges();
        }

        public static List<model.Doctor> GetDoctors()
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            return db.Doctores.ToList();
        }

        public static model.Doctor GetDoctorById(int id)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            return db.Doctores.Find(id);
        }

        public static void UpdateDoctor(model.Doctor doctor)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            db.Doctores.Update(doctor);
            db.SaveChanges();
        }

        public static void DeleteDoctor(int id)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            var doctor = db.Doctores.Find(id);
            if (doctor != null)
            {
                db.Doctores.Remove(doctor);
                db.SaveChanges();
            }
        }
    }
}
