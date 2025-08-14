using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hospital.model
{
    public class Cita
    {
        [Key]
        public int ID { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Historial> Historiales { get; set; }

        public Cita(int DoctorId,int pacienteId ,DateTime date)
        {           
            this.DoctorID = DoctorId;
            this.PacienteID = pacienteId;
            this.Date = date;
        }
        public Cita()
        {
            
        }
    }
}
