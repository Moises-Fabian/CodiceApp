using System;

namespace CodiceApp.Modelo.Entidades
{
    public class Calificacion
    {
        public int Id { get; set; }
        public string RutEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public decimal Nota { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreEstudiante { get; set; }
        public string NombreAsignatura { get; set; }
    }
}