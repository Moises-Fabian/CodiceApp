using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodiceApp.Servicio
{
    public class TrabajoServicio : ITrabajoServicio
    {
        private readonly List<Trabajo> _trabajos = new List<Trabajo>();
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IAsignaturaServicio _asignaturaServicio;
        private int _nextId = 1;

        public TrabajoServicio(IEstudianteServicio estudianteServicio, IAsignaturaServicio asignaturaServicio)
        {
            _estudianteServicio = estudianteServicio;
            _asignaturaServicio = asignaturaServicio;
        }

        public List<Trabajo> ObtenerTodos() => _trabajos;

        public void Agregar(Trabajo trabajo)
        {
            var estudiante = _estudianteServicio.ObtenerTodos().FirstOrDefault(e => e.Rut == trabajo.RutEstudiante);
            var asignatura = _asignaturaServicio.ObtenerTodas().FirstOrDefault(a => a.Id == trabajo.IdAsignatura);

            if (estudiante == null) throw new Exception("El estudiante no existe.");
            if (asignatura == null) throw new Exception("La asignatura no existe.");

            trabajo.Id = _nextId++;
            trabajo.NombreEstudiante = $"{estudiante.Nombre} {estudiante.Apellido}";
            trabajo.NombreAsignatura = asignatura.Nombre;

            _trabajos.Add(trabajo);
        }

        public void Editar(Trabajo trabajoActualizado)
        {
            var trabajo = _trabajos.FirstOrDefault(t => t.Id == trabajoActualizado.Id);
            if (trabajo != null)
            {
                var estudiante = _estudianteServicio.ObtenerTodos().FirstOrDefault(e => e.Rut == trabajoActualizado.RutEstudiante);
                var asignatura = _asignaturaServicio.ObtenerTodas().FirstOrDefault(a => a.Id == trabajoActualizado.IdAsignatura);

                if (estudiante == null) throw new Exception("El estudiante no existe.");
                if (asignatura == null) throw new Exception("La asignatura no existe.");

                trabajo.RutEstudiante = trabajoActualizado.RutEstudiante;
                trabajo.IdAsignatura = trabajoActualizado.IdAsignatura;
                trabajo.NombreTrabajo = trabajoActualizado.NombreTrabajo;
                trabajo.FechaEntrega = trabajoActualizado.FechaEntrega;
                trabajo.FechaLimite = trabajoActualizado.FechaLimite;
                trabajo.NombreEstudiante = $"{estudiante.Nombre} {estudiante.Apellido}";
                trabajo.NombreAsignatura = asignatura.Nombre;
            }
        }

        public void Eliminar(int id)
        {
            var trabajo = _trabajos.FirstOrDefault(t => t.Id == id);
            if (trabajo != null)
            {
                _trabajos.Remove(trabajo);
            }
        }
    }
}