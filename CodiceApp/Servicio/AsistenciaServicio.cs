using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodiceApp.Servicio
{
    public class AsistenciaServicio : IAsistenciaServicio
    {
        private readonly List<Asistencia> _asistencias = new List<Asistencia>();
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IAsignaturaServicio _asignaturaServicio;
        private int _nextId = 1;

        public AsistenciaServicio(IEstudianteServicio estudianteServicio, IAsignaturaServicio asignaturaServicio)
        {
            _estudianteServicio = estudianteServicio;
            _asignaturaServicio = asignaturaServicio;
        }

        public List<Asistencia> ObtenerTodaLaAsistencia()
        {
            return _asistencias;
        }

        public List<Asistencia> ObtenerAsistenciaPorFechaYAsignatura(int idAsignatura, DateTime fecha)
        {
            return _asistencias.Where(a => a.IdAsignatura == idAsignatura && a.Fecha.Date == fecha.Date).ToList();
        }

        public void RegistrarAsistencia(string rutEstudiante, int idAsignatura, DateTime fecha, bool presente)
        {
            var estudiante = _estudianteServicio.ObtenerTodos().FirstOrDefault(e => e.Rut == rutEstudiante);
            var asignatura = _asignaturaServicio.ObtenerTodas().FirstOrDefault(a => a.Id == idAsignatura);

            if (estudiante == null) throw new Exception("El estudiante no existe.");
            if (asignatura == null) throw new Exception("La asignatura no existe.");

            var registroExistente = _asistencias.FirstOrDefault(a => a.RutEstudiante == rutEstudiante && a.IdAsignatura == idAsignatura && a.Fecha.Date == fecha.Date);
            if (registroExistente != null)
            {
                registroExistente.Presente = presente;
                return;
            }

            var nuevaAsistencia = new Asistencia
            {
                Id = _nextId++,
                RutEstudiante = rutEstudiante,
                IdAsignatura = idAsignatura,
                Fecha = fecha,
                Presente = presente,
                NombreEstudiante = $"{estudiante.Nombre} {estudiante.Apellido}",
                NombreAsignatura = asignatura.Nombre
            };
            _asistencias.Add(nuevaAsistencia);
        }
    }
}