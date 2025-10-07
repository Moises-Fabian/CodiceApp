using CodiceApp.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CodiceApp.Vista.Interface
{
    public interface ICalificacionVista
    {
        string RutEstudiante { get; set; }
        string IdAsignatura { get; set; }
        string Nota { get; set; }
        DateTime Fecha { get; set; }
        string Promedio { set; }

        event EventHandler CargarCalificaciones;
        event EventHandler GuardarCalificacion;
        event EventHandler CalcularPromedio;

        void MostrarCalificaciones(List<Calificacion> calificaciones);
        void MostrarMensaje(string mensaje);
    }
}