using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Interface;
using System;

namespace CodiceApp.Presentador
{
    public class AsignaturaPresentador
    {
        private readonly IAsignaturaVista _vista;
        private readonly IAsignaturaServicio _servicio;

        public AsignaturaPresentador(IAsignaturaVista vista, IAsignaturaServicio servicio)
        {
            _vista = vista;
            _servicio = servicio;

            _vista.CargarAsignaturas += OnCargarAsignaturas;
            _vista.AgregarAsignatura += OnAgregarAsignatura;
            _vista.EditarAsignatura += OnEditarAsignatura;
            _vista.EliminarAsignatura += OnEliminarAsignatura;
        }

        private void OnCargarAsignaturas(object sender, EventArgs e)
        {
            _vista.MostrarAsignaturas(_servicio.ObtenerTodas());
        }

        private void OnAgregarAsignatura(object sender, EventArgs e)
        {
            if (_servicio.Existe(_vista.Codigo))
            {
                _vista.MostrarMensaje("El código de la asignatura ya existe.");
                return;
            }

            var nuevaAsignatura = new Asignatura
            {
                Nombre = _vista.Nombre,
                Codigo = _vista.Codigo,
                Descripcion = _vista.Descripcion
            };

            _servicio.Agregar(nuevaAsignatura);
            _vista.MostrarAsignaturas(_servicio.ObtenerTodas());
        }

        private void OnEditarAsignatura(object sender, EventArgs e)
        {
            if (int.TryParse(_vista.Id, out int id))
            {
                var asignatura = new Asignatura
                {
                    Id = id,
                    Nombre = _vista.Nombre,
                    Codigo = _vista.Codigo,
                    Descripcion = _vista.Descripcion
                };
                _servicio.Editar(asignatura);
                _vista.MostrarAsignaturas(_servicio.ObtenerTodas());
            }
            else
            {
                _vista.MostrarMensaje("Por favor, ingrese un ID válido para editar.");
            }
        }

        private void OnEliminarAsignatura(object sender, EventArgs e)
        {
            if (int.TryParse(_vista.Id, out int id))
            {
                _servicio.Eliminar(id);
                _vista.MostrarAsignaturas(_servicio.ObtenerTodas());
            }
            else
            {
                _vista.MostrarMensaje("Por favor, ingrese un ID válido para eliminar.");
            }
        }
    }
}