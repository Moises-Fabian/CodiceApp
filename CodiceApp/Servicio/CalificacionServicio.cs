using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodiceApp.Servicio
{
    public class CalificacionServicio : ICalificacionServicio
    {
        private readonly List<Calificacion> _calificaciones = new List<Calificacion>();
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IAsignaturaServicio _asignaturaServicio;
        private int _nextId = 1;

        public CalificacionServicio(IEstudianteServicio estudianteServicio, IAsignaturaServicio asignaturaServicio)
        {
            _estudianteServicio = estudianteServicio;
            _asignaturaServicio = asignaturaServicio;
        }

        public List<Calificacion> ObtenerTodas() => _calificaciones;

        public void Agregar(Calificacion calificacion)
        {
            var estudiante = _estudianteServicio.ObtenerTodos().FirstOrDefault(e => e.Rut == calificacion.RutEstudiante);
            var asignatura = _asignaturaServicio.ObtenerTodas().FirstOrDefault(a => a.Id == calificacion.IdAsignatura);

            if (estudiante == null) throw new Exception("El estudiante no existe.");
            if (asignatura == null) throw new Exception("La asignatura no existe.");

            calificacion.Id = _nextId++;
            calificacion.NombreEstudiante = $"{estudiante.Nombre} {estudiante.Apellido}";
            calificacion.NombreAsignatura = asignatura.Nombre;

            _calificaciones.Add(calificacion);
        }

        public decimal CalcularPromedio(string rutEstudiante, int idAsignatura)
        {
            var notasDelEstudiante = _calificaciones
                .Where(c => c.RutEstudiante == rutEstudiante && c.IdAsignatura == idAsignatura)
                .Select(c => c.Nota);

            if (notasDelEstudiante.Any())
            {
                return notasDelEstudiante.Average();
            }

            return 0;
        }
    }
}