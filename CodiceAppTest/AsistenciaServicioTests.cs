using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio;
using CodiceApp.Servicio.Interface;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodiceAppTest
{
    [TestFixture]
    public class AsistenciaServicioTests
    {
        private Mock<IEstudianteServicio> _mockEstudianteServicio;
        private Mock<IAsignaturaServicio> _mockAsignaturaServicio;
        private AsistenciaServicio _asistenciaServicio;

        [SetUp]
        public void Setup()
        {
            _mockEstudianteServicio = new Mock<IEstudianteServicio>();
            _mockAsignaturaServicio = new Mock<IAsignaturaServicio>();

            _asistenciaServicio = new AsistenciaServicio(_mockEstudianteServicio.Object, _mockAsignaturaServicio.Object);
        }

        [Test]
        public void RegistrarAsistencia_CuandoDatosSonValidosYNoExisteRegistro_DeberiaCrearNuevoRegistro()
        {
            var estudiante = new Estudiante { Rut = "11-1", Nombre = "Juan", Apellido = "Perez" };
            var asignatura = new Asignatura { Id = 1, Nombre = "Programación" };
            var fecha = DateTime.Now;

            _mockEstudianteServicio.Setup(s => s.ObtenerTodos()).Returns(new List<Estudiante> { estudiante });
            _mockAsignaturaServicio.Setup(s => s.ObtenerTodas()).Returns(new List<Asignatura> { asignatura });

            _asistenciaServicio.RegistrarAsistencia(estudiante.Rut, asignatura.Id, fecha, true);

            var asistencias = _asistenciaServicio.ObtenerTodaLaAsistencia();
            Assert.That(asistencias.Count, Is.EqualTo(1));
            Assert.That(asistencias.First().RutEstudiante, Is.EqualTo(estudiante.Rut));
            Assert.That(asistencias.First().Presente, Is.True);
        }

        [Test]
        public void RegistrarAsistencia_CuandoRegistroYaExiste_DeberiaActualizarlo()
        {
            var estudiante = new Estudiante { Rut = "11-1" };
            var asignatura = new Asignatura { Id = 1 };
            var fecha = DateTime.Now;
            _mockEstudianteServicio.Setup(s => s.ObtenerTodos()).Returns(new List<Estudiante> { estudiante });
            _mockAsignaturaServicio.Setup(s => s.ObtenerTodas()).Returns(new List<Asignatura> { asignatura });

            _asistenciaServicio.RegistrarAsistencia(estudiante.Rut, asignatura.Id, fecha, false);
            _asistenciaServicio.RegistrarAsistencia(estudiante.Rut, asignatura.Id, fecha, true); 

            var asistencias = _asistenciaServicio.ObtenerTodaLaAsistencia();
            Assert.That(asistencias.Count, Is.EqualTo(1)); 
            Assert.That(asistencias.First().Presente, Is.True);
        }

        [Test]
        public void RegistrarAsistencia_CuandoEstudianteNoExiste_DeberiaLanzarExcepcion()
        {
            var asignatura = new Asignatura { Id = 1 };
            _mockEstudianteServicio.Setup(s => s.ObtenerTodos()).Returns(new List<Estudiante>()); 
            _mockAsignaturaServicio.Setup(s => s.ObtenerTodas()).Returns(new List<Asignatura> { asignatura });

            var ex = Assert.Throws<Exception>(() => _asistenciaServicio.RegistrarAsistencia("rut-inexistente", asignatura.Id, DateTime.Now, true));
            Assert.That(ex.Message, Is.EqualTo("El estudiante no existe."));
        }
    }
}