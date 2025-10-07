using CodiceApp.Servicio;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Interface;
using System;

namespace CodiceApp.Presentador
{
    public class AsistenciaPresentador
    {
        private readonly IAsistenciaVista _vista;
        private readonly IAsistenciaServicio _asistenciaServicio;
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IAsignaturaServicio _asignaturaServicio;

        public AsistenciaPresentador(IAsistenciaVista vista, IAsistenciaServicio asistenciaServicio, IEstudianteServicio estudianteServicio, IAsignaturaServicio asignaturaServicio)
        {
            _vista = vista;
            _asistenciaServicio = asistenciaServicio;
            _estudianteServicio = estudianteServicio;
            _asignaturaServicio = asignaturaServicio;

            _vista.CargarAsistencias += OnCargarAsistencias;
            _vista.RegistrarAsistencia += OnRegistrarAsistencia;
        }

        private void OnCargarAsistencias(object sender, EventArgs e)
        {
            _vista.MostrarAsistencias(_asistenciaServicio.ObtenerTodaLaAsistencia());
        }

        private void OnRegistrarAsistencia(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_vista.RutEstudiante))
            {
                _vista.MostrarMensaje("El campo Rut no puede estar vacío.");
                return;
            }

            if (!int.TryParse(_vista.IdAsignatura, out int idAsignatura))
            {
                _vista.MostrarMensaje("El ID de la asignatura debe ser un número válido.");
                return;
            }

            if (!_estudianteServicio.Existe(_vista.RutEstudiante))
            {
                _vista.MostrarMensaje("El estudiante con el Rut ingresado no existe.");
                return;
            }

            if (!_asignaturaServicio.ObtenerTodas().Any(a => a.Id == idAsignatura))
            {
                _vista.MostrarMensaje("La asignatura con el ID ingresado no existe.");
                return;
            }

            try
            {
                _asistenciaServicio.RegistrarAsistencia(
                    _vista.RutEstudiante,
                    idAsignatura,
                    _vista.Fecha,
                    _vista.Presente
                );

                _vista.MostrarAsistencias(_asistenciaServicio.ObtenerTodaLaAsistencia());
            }
            catch (Exception ex)
            {
                _vista.MostrarMensaje("Error al registrar la asistencia: " + ex.Message);
            }
        }
    }
}