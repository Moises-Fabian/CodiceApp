using System;

namespace CodiceApp.Modelo.Entidades
{
    public class Asistencia
    {
        public int Id { get; set; }
        public string RutEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public DateTime Fecha { get; set; }
        public bool Presente { get; set; } 
        public string NombreEstudiante { get; set; }
        public string NombreAsignatura { get; set; }
    }
}