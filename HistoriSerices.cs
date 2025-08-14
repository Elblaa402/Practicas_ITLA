using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using hospital.model;
using Hospital.dbcontext;

public class HistorialService
{
    public ClinicaContext _context;

    public HistorialService(ClinicaContext context)
    {
        _context = context;
    }

    // Función para obtener todo el historial o filtrado por fecha
    public List<Historial> ObtenerHistorial(DateTime? fechaInicio = null, DateTime? fechaFin = null)
    {
        var query = _context.Historiales
            .Include(h => h.Doctor)
            .Include(h => h.Paciente)
            .Include(h => h.Cita)
            .AsQueryable();

        if (fechaInicio.HasValue && fechaFin.HasValue)
        {
            query = query.Where(h => h.Date >= fechaInicio.Value && h.Date <= fechaFin.Value);
        }
        else if (fechaInicio.HasValue) // Solo desde fecha
        {
            query = query.Where(h => h.Date >= fechaInicio.Value);
        }
        else if (fechaFin.HasValue) // Solo hasta fecha
        {
            query = query.Where(h => h.Date <= fechaFin.Value);
        }

        return query
            .OrderBy(h => h.Date)
            .ToList();


    }

}