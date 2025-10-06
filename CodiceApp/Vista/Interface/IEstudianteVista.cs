using CodiceApp.Modelo.Entidades;
using CodiceApp.Vista.Forms.Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodiceApp.Vista.Interface
{
    public interface IEstudianteVista
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        event EventHandler CargarEstudiantes;
        event EventHandler AgregarEstudiante;
        event EventHandler EditarEstudiante;
        event EventHandler EliminarEstudiante;

        void MostrarEstudiantes(List<Estudiante> estudiantes);
        void MostrarMensaje(string mensaje);
    }
}
