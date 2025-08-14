using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hospital.model
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Cellphone { get; set; }

        [Required]
        public string Especialidad { get; set; }

        public ICollection<Cita> Citas { get; set; }
        public ICollection<Historial> Historiales { get; set; }

        public Doctor()
        {
            Citas = new List<Cita>();
            Historiales = new List<Historial>();
        }
    }
}
