using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio;
using NUnit.Framework;
using System.Linq;

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
            var nuevoEstudiante = new Estudiante { Rut = "33-3", Nombre = "Carlos", Apellido = "Soto" };
            var totalInicial = _estudianteServicio.ObtenerTodos().Count;

            _estudianteServicio.Agregar(nuevoEstudiante);

            var estudiantes = _estudianteServicio.ObtenerTodos();
            Assert.That(estudiantes.Count, Is.EqualTo(totalInicial + 1));
            Assert.That(estudiantes.Any(e => e.Rut == "33-3"), Is.True);
        }

        [Test]
        public void Editar_CuandoEstudianteExiste_DeberiaActualizarLosDatos()
        {
            var rutExistente = "11-1";
            var estudianteActualizado = new Estudiante { Rut = rutExistente, Nombre = "Juanito", Apellido = "Pérez Modificado" };

            _estudianteServicio.Editar(estudianteActualizado);

            var estudiante = _estudianteServicio.ObtenerTodos().First(e => e.Rut == rutExistente);
            Assert.That(estudiante.Nombre, Is.EqualTo("Juanito"));
        }

        [Test] 
        public void Eliminar_CuandoEstudianteExiste_DeberiaQuitarloDeLaLista()
        {
            var rutAEliminar = "22-2";
            var totalInicial = _estudianteServicio.ObtenerTodos().Count;

            _estudianteServicio.Eliminar(rutAEliminar);

            var estudiantes = _estudianteServicio.ObtenerTodos();
            Assert.That(estudiantes.Count, Is.EqualTo(totalInicial - 1));
            Assert.That(estudiantes.Any(e => e.Rut == rutAEliminar), Is.False);
        }
    }
}