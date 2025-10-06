using CodiceApp.Modelo.Entidades;
using System.Collections.Generic;

namespace CodiceApp.Servicio.Interface
{
    public interface IAsignaturaServicio
    {
        List<Asignatura> ObtenerTodas();
        void Agregar(Asignatura asignatura);
        void Editar(Asignatura asignatura);
        void Eliminar(int id);
        bool Existe(string codigo);
    }
}