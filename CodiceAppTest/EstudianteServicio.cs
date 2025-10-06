using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio;
using NUnit.Framework;
using System.Linq;

namespace CodiceApp.Tests
{
    [TestFixture]
    public class EstudianteServicioTests
    {
        private EstudianteServicio _estudianteServicio;

        // Este método se ejecuta antes de cada prueba, 
        // asegurando que cada test comience con una lista de estudiantes limpia.
        [SetUp]
        public void Setup()
        {
            _estudianteServicio = new EstudianteServicio();
        }

        [Test]
        public void Agregar_CuandoEstudianteEsValido_DeberiaAnadirloALaLista()
        {
            // Arrange: Preparamos los datos de un nuevo estudiante.
            var nuevoEstudiante = new Estudiante { Rut = "33-3", Nombre = "Carlos", Apellido = "Soto" };
            var totalInicial = _estudianteServicio.ObtenerTodos().Count; // Contamos cuántos hay al inicio (2).

            // Act: Ejecutamos el método que queremos probar.
            _estudianteServicio.Agregar(nuevoEstudiante);

            // Assert: Verificamos que el resultado es el esperado.
            var estudiantes = _estudianteServicio.ObtenerTodos();
            Assert.That(estudiantes.Count, Is.EqualTo(totalInicial + 1)); // El total debe ser 3 ahora.
            Assert.That(estudiantes.Any(e => e.Rut == "33-3"), Is.True); // Verificamos que el nuevo estudiante existe en la lista.
        }

        [Test]
        public void Editar_CuandoEstudianteExiste_DeberiaActualizarLosDatos()
        {
            // Arrange: Preparamos los datos actualizados para un estudiante que ya existe.
            var rutExistente = "11-1"; // Este Rut viene de los datos iniciales del servicio.
            var estudianteActualizado = new Estudiante { Rut = rutExistente, Nombre = "Juanito", Apellido = "Pérez Modificado" };

            // Act: Ejecutamos el método de edición.
            _estudianteServicio.Editar(estudianteActualizado);

            // Assert: Verificamos que los datos del estudiante fueron realmente modificados.
            var estudiante = _estudianteServicio.ObtenerTodos().First(e => e.Rut == rutExistente);
            Assert.That(estudiante.Nombre, Is.EqualTo("Juanito"));
            Assert.That(estudiante.Apellido, Is.EqualTo("Pérez Modificado"));
        }

        [Test]
        public void Eliminar_CuandoEstudianteExiste_DeberiaQuitarloDeLaLista()
        {
            // Arrange: Definimos el Rut del estudiante a eliminar.
            var rutAEliminar = "22-2";
            var totalInicial = _estudianteServicio.ObtenerTodos().Count; // El total inicial es 2.

            // Act: Ejecutamos el método de eliminación.
            _estudianteServicio.Eliminar(rutAEliminar);

            // Assert: Verificamos que la lista ahora tiene un elemento menos y que el estudiante ya no existe.
            var estudiantes = _estudianteServicio.ObtenerTodos();
            Assert.That(estudiantes.Count, Is.EqualTo(totalInicial - 1));
            Assert.That(estudiantes.Any(e => e.Rut == rutAEliminar), Is.False);
        }
    }
}