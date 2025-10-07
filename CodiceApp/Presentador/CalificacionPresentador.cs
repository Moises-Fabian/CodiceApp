using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Interface;
using System;

namespace CodiceApp.Presentador
{
    public class CalificacionPresentador
    {
        private readonly ICalificacionVista _vista;
        private readonly ICalificacionServicio _servicio;

        public CalificacionPresentador(ICalificacionVista vista, ICalificacionServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;

            _vista.CargarCalificaciones += OnCargarCalificaciones;
            _vista.EditarCalificacion += OnEditarCalificacion;  
            _vista.EliminarCalificacion += OnEliminarCalificacion;
            _vista.GuardarCalificacion += OnGuardarCalificacion;
            _vista.CalcularPromedio += OnCalcularPromedio;
        }

        private void OnCargarCalificaciones(object sender, EventArgs e)
        {
            _vista.MostrarCalificaciones(_servicio.ObtenerTodas());
        }

        private void OnGuardarCalificacion(object sender, EventArgs e)
        {
            if (!decimal.TryParse(_vista.Nota, out decimal nota))
            {
                _vista.MostrarMensaje("La nota ingresada no es un número válido.");
                return;
            }

            if (!int.TryParse(_vista.IdAsignatura, out int idAsignatura))
            {
                _vista.MostrarMensaje("El ID de la asignatura no es un número válido.");
                return;
            }

            try
            {
                var nuevaCalificacion = new Calificacion
                {
                    RutEstudiante = _vista.RutEstudiante,
                    IdAsignatura = idAsignatura,
                    Nota = nota,
                    Fecha = _vista.Fecha
                };

                _servicio.Agregar(nuevaCalificacion);
                _vista.MostrarCalificaciones(_servicio.ObtenerTodas());
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        private void OnEditarCalificacion(object sender, EventArgs e)
        {
            if (!int.TryParse(_vista.Id, out int id))
            {
                _vista.MostrarMensaje("El ID de la calificación a editar no es válido.");
                return;
            }
            if (!decimal.TryParse(_vista.Nota, out decimal nota))
            {
                _vista.MostrarMensaje("La nota ingresada no es un número válido.");
                return;
            }
            if (!int.TryParse(_vista.IdAsignatura, out int idAsignatura))
            {
                _vista.MostrarMensaje("El ID de la asignatura no es un número válido.");
                return;
            }

            try
            {
                var calificacionActualizada = new Calificacion
                {
                    Id = id,
                    RutEstudiante = _vista.RutEstudiante,
                    IdAsignatura = idAsignatura,
                    Nota = nota,
                    Fecha = _vista.Fecha
                };

                _servicio.Editar(calificacionActualizada);
                _vista.MostrarCalificaciones(_servicio.ObtenerTodas());
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje(ex.Message);
            }
        }

        private void OnEliminarCalificacion(object sender, EventArgs e)
        {
            if (!int.TryParse(_vista.Id, out int id))
            {
                _vista.MostrarMensaje("El ID de la calificación a eliminar no es válido.");
                return;
            }

            _servicio.Eliminar(id);
            _vista.MostrarCalificaciones(_servicio.ObtenerTodas());
        }

        private void OnCalcularPromedio(object sender, EventArgs e)
        {
            if (!int.TryParse(_vista.IdAsignatura, out int idAsignatura))
            {
                _vista.MostrarMensaje("El ID de la asignatura no es un número válido para calcular el promedio.");
                return;
            }

            var promedio = _servicio.CalcularPromedio(_vista.RutEstudiante, idAsignatura);

            if (promedio >= 4.0m)
            {
                _vista.SetPromedioColor(Color.Blue);
            }
            else
            {
                _vista.SetPromedioColor(Color.Red);
            }
            _vista.Promedio = $"Promedio: {promedio:F2}";
        }
    }
}