using CodiceApp.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace CodiceApp.Vista.Interface
{
    public interface IAsignaturaVista
    {
        string Id { get; set; }
        string Nombre { get; set; }
        string Codigo { get; set; }
        string Descripcion { get; set; }

        event EventHandler CargarAsignaturas;
        event EventHandler AgregarAsignatura;
        event EventHandler EditarAsignatura;
        event EventHandler EliminarAsignatura;

        void MostrarAsignaturas(List<Asignatura> asignaturas);
        void MostrarMensaje(string mensaje);
    }
}