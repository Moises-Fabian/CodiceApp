using CodiceApp.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CodiceApp.Vista.Interface
{
    public interface ITrabajoVista
    {
        string Id { get; set; }
        string RutEstudiante { get; set; }
        string IdAsignatura { get; set; }
        string NombreTrabajo { get; set; }
        DateTime FechaEntrega { get; set; }
        DateTime FechaLimite { get; set; }

        event EventHandler CargarTrabajos;
        event EventHandler AgregarTrabajo;
        event EventHandler EditarTrabajo;
        event EventHandler EliminarTrabajo;

        void MostrarTrabajos(List<Trabajo> trabajos);
        void MostrarMensaje(string mensaje);
    }
}