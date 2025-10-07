using System;

namespace CodiceApp.Modelo.Entidades
{
    public class Trabajo
    {
        public int Id { get; set; }
        public string RutEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public string NombreTrabajo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaLimite { get; set; }
        public string NombreEstudiante { get; set; }
        public string NombreAsignatura { get; set; }
    }
}