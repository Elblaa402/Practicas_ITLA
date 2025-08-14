using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using hospital.model;
 
namespace hospital.services
{
    public class CitasServices
    {
        public static void AddCita(int pacienteId, int doctorId, DateTime date)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            var cita = new model.Cita
            {
                PacienteID = pacienteId,
                DoctorID = doctorId,
                Date = date
            };
            db.Citas.Add(cita);
            db.SaveChanges();
        }
        public static List<model.Cita> GetCitas()
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            return db.Citas.ToList();
        }
        public static model.Cita GetCitaById(int id)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            return db.Citas.Find(id);
        }
        public static void UpdateCita(model.Cita cita)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            db.Citas.Update(cita);
            db.SaveChanges();
        }
        public static void DeleteCita(int id)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            var cita = db.Citas.Find(id);
            if (cita != null)
            {
                db.Citas.Remove(cita);
                db.SaveChanges();
            }
        }

    }
}
