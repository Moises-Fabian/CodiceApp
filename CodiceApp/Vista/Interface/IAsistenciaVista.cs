using CodiceApp.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CodiceApp.Vista.Interface
{
    public interface IAsistenciaVista
    {
        string RutEstudiante { get; set; }
        string IdAsignatura { get; set; }
        DateTime Fecha { get; set; }
        bool Presente { get; set; }

        event EventHandler CargarAsistencias; 
        event EventHandler RegistrarAsistencia;

        void MostrarAsistencias(List<Asistencia> asistencias);
        void MostrarMensaje(string mensaje);
    }
}