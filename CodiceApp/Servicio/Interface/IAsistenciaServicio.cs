using CodiceApp.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CodiceApp.Servicio.Interface
{
    public interface IAsistenciaServicio
    {
        void RegistrarAsistencia(string rutEstudiante, int idAsignatura, DateTime fecha, bool presente);
        List<Asistencia> ObtenerAsistenciaPorFechaYAsignatura(int idAsignatura, DateTime fecha);
        List<Asistencia> ObtenerTodaLaAsistencia();
    }
}