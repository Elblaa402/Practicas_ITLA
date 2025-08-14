using System;
using System.ComponentModel.DataAnnotations;

namespace hospital.model
{
    public class Historial
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        [Required]
        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; }

        [Required]
        public int CitaID { get; set; }
        public Cita Cita { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Detalles { get; set; }
    }
}
