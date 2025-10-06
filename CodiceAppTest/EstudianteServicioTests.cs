using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio;
using CodiceApp.Servicio.Interface; // Necesario para los mocks si los usaras
using NUnit.Framework;
using System.Collections.Generic;    // Necesario para List<T>
using System.Linq;

// CAMBIO: El namespace ahora coincide con el nombre del proyecto
namespace CodiceAppTest
{
    [TestFixture]
    public class EstudianteServicioTests
    {
        private EstudianteServicio _estudianteServicio;

        [SetUp]
        public void Setup()
        {
            _estudianteServicio = new EstudianteServicio();
        }

        [Test]
        public void Agregar_CuandoEstudianteEsValido_DeberiaAnadirloALaLista()
        {
            // Arrange
            var nuevoEstudiante = new Estudiante { Rut = "33-3", Nombre = "Carlos", Apellido = "Soto" };
            var totalInicial = _estudianteServicio.ObtenerTodos().Count;

            // Act
            _estudianteServicio.Agregar(nuevoEstudiante);

            // Assert
            var estudiantes = _estudianteServicio.ObtenerTodos();
            Assert.That(estudiantes.Count, Is.EqualTo(totalInicial + 1));
            Assert.That(estudiantes.Any(e => e.Rut == "33-3"), Is.True);
        }

        [Test]
        public void Editar_CuandoEstudianteExiste_DeberiaActualizarLosDatos()
        {
            // Arrange
            var rutExistente = "11-1";
            var estudianteActualizado = new Estudiante { Rut = rutExistente, Nombre = "Juanito", Apellido = "Pérez Modificado" };

            // Act
            _estudianteServicio.Editar(estudianteActualizado);

            // Assert
            var estudiante = _estudianteServicio.ObtenerTodos().First(e => e.Rut == rutExistente);
            Assert.That(estudiante.Nombre, Is.EqualTo("Juanito"));
        }

        [Test]
        public void Eliminar_CuandoEstudianteExiste_DeberiaQuitarloDeLaLista()
        {
            // Arrange
            var rutAEliminar = "22-2";
            var totalInicial = _estudianteServicio.ObtenerTodos().Count;

            // Act
            _estudianteServicio.Eliminar(rutAEliminar);

            // Assert
            var estudiantes = _estudianteServicio.ObtenerTodos();
            Assert.That(estudiantes.Count, Is.EqualTo(totalInicial - 1));
            Assert.That(estudiantes.Any(e => e.Rut == rutAEliminar), Is.False);
        }
    }
}