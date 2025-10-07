using CodiceApp.Modelo.Entidades;
using System.Collections.Generic;

namespace CodiceApp.Servicio.Interface
{
    public interface ITrabajoServicio
    {
        void Agregar(Trabajo trabajo);
        void Editar(Trabajo trabajo);
        void Eliminar(int id);
        List<Trabajo> ObtenerTodos();
    }
}