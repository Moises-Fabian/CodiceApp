using CodiceApp.Modelo.Entidades;
using System.Collections.Generic;

namespace CodiceApp.Servicio.Interface
{
    public interface ICalificacionServicio
    {
        void Agregar(Calificacion calificacion);
        void Editar(Calificacion calificacion);
        void Eliminar(int id);
        List<Calificacion> ObtenerTodas();
        decimal CalcularPromedio(string rutEstudiante, int idAsignatura);
    }
}