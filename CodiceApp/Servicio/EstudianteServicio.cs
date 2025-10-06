using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodiceApp.Servicio
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private readonly List<Estudiante> _estudiantes = new List<Estudiante>();

        public EstudianteServicio()
        {
            _estudiantes.Add(new Estudiante { Rut = "11-1", Nombre = "Juan", Apellido = "Pérez", Email = "juan.perez@email.com" });
            _estudiantes.Add(new Estudiante { Rut = "22-2", Nombre = "Ana", Apellido = "García", Email = "ana.garcia@email.com" });
        }

        public List<Estudiante> ObtenerTodos() => _estudiantes;

        public void Agregar(Estudiante estudiante) => _estudiantes.Add(estudiante);

        public void Editar(Estudiante estudianteActualizado)
        {
            var estudiante = _estudiantes.FirstOrDefault(e => e.Rut == estudianteActualizado.Rut);
            if (estudiante != null)
            {
                estudiante.Nombre = estudianteActualizado.Nombre;
                estudiante.Apellido = estudianteActualizado.Apellido;
                estudiante.Email = estudianteActualizado.Email;
            }
        }

        public void Eliminar(string rut)
        {
            var estudiante = _estudiantes.FirstOrDefault(e => e.Rut == rut);
            if (estudiante != null)
            {
                _estudiantes.Remove(estudiante);
            }
        }

        public bool Existe(string rut) => _estudiantes.Any(e => e.Rut == rut);
    }
}
