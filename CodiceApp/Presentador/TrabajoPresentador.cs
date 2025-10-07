using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Interface;
using System;

namespace CodiceApp.Presentador
{
    public class TrabajoPresentador
    {
        private readonly ITrabajoVista _vista;
        private readonly ITrabajoServicio _servicio;

        public TrabajoPresentador(ITrabajoVista vista, ITrabajoServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;

            _vista.CargarTrabajos += OnCargarTrabajos;
            _vista.AgregarTrabajo += OnAgregarTrabajo;
            _vista.EditarTrabajo += OnEditarTrabajo;
            _vista.EliminarTrabajo += OnEliminarTrabajo;
        }

        private void OnCargarTrabajos(object sender, EventArgs e)
        {
            _vista.MostrarTrabajos(_servicio.ObtenerTodos());
        }

        private void OnAgregarTrabajo(object sender, EventArgs e)
        {
            try
            {
                var trabajo = new Trabajo
                {
                    RutEstudiante = _vista.RutEstudiante,
                    IdAsignatura = int.Parse(_vista.IdAsignatura),
                    NombreTrabajo = _vista.NombreTrabajo,
                    FechaEntrega = _vista.FechaEntrega,
                    FechaLimite = _vista.FechaLimite
                };
                _servicio.Agregar(trabajo);
                _vista.MostrarTrabajos(_servicio.ObtenerTodos());
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        private void OnEditarTrabajo(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(_vista.Id, out int id))
                {
                    _vista.MostrarMensaje("Por favor, seleccione un trabajo de la lista para editar.");
                    return;
                }

                var trabajoActualizado = new Trabajo
                {
                    Id = id,
                    RutEstudiante = _vista.RutEstudiante,
                    IdAsignatura = int.Parse(_vista.IdAsignatura),
                    NombreTrabajo = _vista.NombreTrabajo,
                    FechaEntrega = _vista.FechaEntrega,
                    FechaLimite = _vista.FechaLimite
                };

                _servicio.Editar(trabajoActualizado);
                _vista.MostrarTrabajos(_servicio.ObtenerTodos());
            }
            catch (FormatException)
            {
                _vista.MostrarMensaje("El ID de la asignatura debe ser un número válido.");
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        private void OnEliminarTrabajo(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(_vista.Id, out int id))
                {
                    _vista.MostrarMensaje("Por favor, seleccione un trabajo de la lista para eliminar.");
                    return;
                }

                _servicio.Eliminar(id);
                _vista.MostrarTrabajos(_servicio.ObtenerTodos());
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje("Ocurrió un error al eliminar: " + ex.Message);
            }
        }
    }
}