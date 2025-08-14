using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital.services
{
    internal class pacientesCervices
    {
        public static void AddPaciente(string name, string lastname, string cellphone)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            var paciente = new model.Paciente
            {
                Name = name,
                Lastname = lastname,
                Cellphone = cellphone
            };
            db.Pacientes.Add(paciente);
            db.SaveChanges();
        }
        public static List<model.Paciente> GetPacientes()
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            return db.Pacientes.ToList();
        }
        public static model.Paciente GetPacienteById(int id)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            return db.Pacientes.Find(id);
        }
        public static void UpdatePaciente(model.Paciente paciente)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            db.Pacientes.Update(paciente);
            db.SaveChanges();
        }
        public static void DeletePaciente(int id)
        {
            using var db = new Hospital.dbcontext.ClinicaContext();
            var paciente = db.Pacientes.Find(id);
            if (paciente != null)
            {
                db.Pacientes.Remove(paciente);
                db.SaveChanges();
            }
        }
    }
}
