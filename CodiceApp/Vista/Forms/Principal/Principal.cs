using CodiceApp.Presentador;
using CodiceApp.Servicio;
using CodiceApp.Servicio.Interface;
using CodiceApp.Vista.Forms;
using CodiceApp.Vista.Forms.Alumnos;
using CodiceApp.Vista.Forms.Asignaturas;
using CodiceApp.Vista.Forms.Asistencia;
using CodiceApp.Vista.Forms.Calificaciones;
using CodiceApp.Vista.Interface;

namespace CodiceApp
{
    public partial class Principal : Form
    {
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IAsignaturaServicio _asignaturaServicio;
        private readonly IAsistenciaServicio _asistenciaServicio;
        private readonly ICalificacionServicio _calificacionServicio;
        private readonly ITrabajoServicio _trabajoServicio;
        public Principal()
        {
            InitializeComponent();
            _estudianteServicio = new EstudianteServicio();
            _asignaturaServicio = new AsignaturaServicio();
            _asistenciaServicio = new AsistenciaServicio(_estudianteServicio, _asignaturaServicio);
            _calificacionServicio = new CalificacionServicio(_estudianteServicio, _asignaturaServicio);
            _trabajoServicio = new TrabajoServicio(_estudianteServicio, _asignaturaServicio);
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            IEstudianteVista vista = new FormEstudiantes();
            EstudiantePresentador presentador = new EstudiantePresentador(vista, _estudianteServicio);

            ((Form)vista).ShowDialog();
        }

        private void btn_asignaturas_Click(object sender, EventArgs e)
        {
            IAsignaturaVista vista = new FormAsignaturas();
            AsignaturaPresentador presentador = new AsignaturaPresentador(vista, _asignaturaServicio);
            ((Form)vista).ShowDialog();
        }

        private void btn_calificaciones_Click(object sender, EventArgs e)
        {
            ICalificacionVista vista = new FormCalificaciones();
            CalificacionPresentador presentador = new CalificacionPresentador(vista, _calificacionServicio);
            ((Form)vista).ShowDialog();
        }

        private void btnGestionarAsistencia_Click(object sender, EventArgs e)
        {
            IAsistenciaVista vista = new FormAsistencia();
            AsistenciaPresentador presentador = new AsistenciaPresentador(vista, _asistenciaServicio, _estudianteServicio, _asignaturaServicio);
            ((Form)vista).ShowDialog();
        }

        private void btn_informes_Click(object sender, EventArgs e)
        {
            ITrabajoVista vista = new FormTrabajos();
            TrabajoPresentador presentador = new TrabajoPresentador(vista, _trabajoServicio);
            ((Form)vista).ShowDialog();
        }
    }
}
