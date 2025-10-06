using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CodiceApp.Servicio
{
    public class AsignaturaServicio : IAsignaturaServicio
    {
        private readonly List<Asignatura> _asignaturas = new List<Asignatura>();
        private int _nextId = 1;

        public AsignaturaServicio()
        {
            Agregar(new Asignatura { Nombre = "Programación Orientada a Objetos", Codigo = "PROG-001", Descripcion = "Fundamentos de C#" });
            Agregar(new Asignatura { Nombre = "Bases de Datos", Codigo = "DATA-001", Descripcion = "Manejo de SQL Server" });
        }

        public List<Asignatura> ObtenerTodas() => _asignaturas;

        public void Agregar(Asignatura asignatura)
        {
            asignatura.Id = _nextId++;
            _asignaturas.Add(asignatura);
        }

        public void Editar(Asignatura asignaturaActualizada)
        {
            var asignatura = _asignaturas.FirstOrDefault(a => a.Id == asignaturaActualizada.Id);
            if (asignatura != null)
            {
                asignatura.Nombre = asignaturaActualizada.Nombre;
                asignatura.Codigo = asignaturaActualizada.Codigo;
                asignatura.Descripcion = asignaturaActualizada.Descripcion;
            }
        }

        public void Eliminar(int id)
        {
            var asignatura = _asignaturas.FirstOrDefault(a => a.Id == id);
            if (asignatura != null)
            {
                _asignaturas.Remove(asignatura);
            }
        }

        public bool Existe(string codigo) => _asignaturas.Any(a => a.Codigo.Equals(codigo, System.StringComparison.OrdinalIgnoreCase));
    }
}