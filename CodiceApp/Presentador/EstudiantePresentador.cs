using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Interface;
using System;

namespace CodiceApp.Presentador
{
    public class EstudiantePresentador
    {
        private readonly IEstudianteVista _vista;
        private readonly IEstudianteServicio _servicio;

        public EstudiantePresentador(IEstudianteVista vista, IEstudianteServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;

            _vista.CargarEstudiantes += OnCargarEstudiantes;
            _vista.AgregarEstudiante += OnAgregarEstudiante;
            _vista.EditarEstudiante += OnEditarEstudiante;
            _vista.EliminarEstudiante += OnEliminarEstudiante;
        }

        private void OnCargarEstudiantes(object sender, EventArgs e)
        {
            _vista.MostrarEstudiantes(_servicio.ObtenerTodos());
        }

        private void OnAgregarEstudiante(object sender, EventArgs e)
        {
            if (_servicio.Existe(_vista.Rut))
            {
                _vista.MostrarMensaje("El Rut ya existe.");
                return;
            }

            var nuevoEstudiante = new Estudiante
            {
                Rut = _vista.Rut,
                Nombre = _vista.Nombre,
                Apellido = _vista.Apellido,
                Email = _vista.Email
            };


            _servicio.Agregar(nuevoEstudiante);
            _vista.MostrarEstudiantes(_servicio.ObtenerTodos()); 
        }

        private void OnEditarEstudiante(object sender, EventArgs e)
        {
            var estudiante = new Estudiante
            {
                Rut = _vista.Rut,
                Nombre = _vista.Nombre,
                Apellido = _vista.Apellido,
                Email = _vista.Email
            };

            _servicio.Editar(estudiante);
            _vista.MostrarEstudiantes(_servicio.ObtenerTodos());
        }

        private void OnEliminarEstudiante(object sender, EventArgs e)
        {
            _servicio.Eliminar(_vista.Rut);
            _vista.MostrarEstudiantes(_servicio.ObtenerTodos());
        }
    }
}