using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hospital.model
{
    public class Paciente
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Cellphone { get; set; }

        public ICollection<Cita> Citas { get; set; }
        public ICollection<Historial> Historiales { get; set; }

        public Paciente()
        {
            Citas = new List<Cita>();
            Historiales = new List<Historial>();
        }
    }
}
