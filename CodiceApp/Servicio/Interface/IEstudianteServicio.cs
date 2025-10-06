using CodiceApp.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodiceApp.Servicio.Interface
{
    public interface IEstudianteServicio
    {
        List<Estudiante> ObtenerTodos();
        void Agregar(Estudiante estudiante);
        void Editar(Estudiante estudiante);
        void Eliminar(string rut);
        bool Existe(string rut);
    }
}
