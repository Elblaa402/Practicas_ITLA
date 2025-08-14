using hospital.model;
using Microsoft.EntityFrameworkCore;

namespace Hospital.dbcontext
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext() { }

        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Historial> Historiales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-I2E36T3;Database=Hospital;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Historial>()
                .HasOne(h => h.Doctor)
                .WithMany(d => d.Historiales)
                .HasForeignKey(h => h.DoctorID)
                .OnDelete(DeleteBehavior.Restrict);

            
            modelBuilder.Entity<Historial>()
                .HasOne(h => h.Paciente)
                .WithMany(p => p.Historiales)
                .HasForeignKey(h => h.PacienteID)
                .OnDelete(DeleteBehavior.Restrict);

            
            modelBuilder.Entity<Historial>()
                .HasOne(h => h.Cita)
                .WithMany(c => c.Historiales)
                .HasForeignKey(h => h.CitaID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

