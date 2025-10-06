using CodiceApp.Modelo.Entidades;
using CodiceApp.Servicio;
using NUnit.Framework;
using System.Linq;

namespace CodiceAppTest
{
    [TestFixture]
    public class AsignaturaServicioTests
    {
        private AsignaturaServicio _asignaturaServicio;

        [SetUp]
        public void Setup()
        {
            _asignaturaServicio = new AsignaturaServicio();
        }

        [Test]
        public void Agregar_CuandoAsignaturaEsValida_DeberiaAnadirlaALaLista()
        {
            var nuevaAsignatura = new Asignatura { Nombre = "Cálculo", Codigo = "CALC-101" };
            var totalInicial = _asignaturaServicio.ObtenerTodas().Count;

            _asignaturaServicio.Agregar(nuevaAsignatura);

            var asignaturas = _asignaturaServicio.ObtenerTodas();
            Assert.That(asignaturas.Count, Is.EqualTo(totalInicial + 1));
            Assert.That(asignaturas.Any(a => a.Codigo == "CALC-101"), Is.True);
        }

        [Test]
        public void Editar_CuandoAsignaturaExiste_DeberiaActualizarDatos()
        {
            var idExistente = 1;
            var asignaturaActualizada = new Asignatura { Id = idExistente, Nombre = "Programación Avanzada", Codigo = "PROG-001" };

            _asignaturaServicio.Editar(asignaturaActualizada);

            var asignatura = _asignaturaServicio.ObtenerTodas().First(a => a.Id == idExistente);
            Assert.That(asignatura.Nombre, Is.EqualTo("Programación Avanzada"));
        }

        [Test]
        public void Eliminar_CuandoAsignaturaExiste_DeberiaQuitarlaDeLaLista()
        {
            var idAEliminar = 2;
            var totalInicial = _asignaturaServicio.ObtenerTodas().Count;

            _asignaturaServicio.Eliminar(idAEliminar);

            var asignaturas = _asignaturaServicio.ObtenerTodas();
            Assert.That(asignaturas.Count, Is.EqualTo(totalInicial - 1));
            Assert.That(asignaturas.Any(a => a.Id == idAEliminar), Is.False);
        }
    }
}